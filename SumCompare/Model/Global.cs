using SumCompare.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace SumCompare;

public static class Global
{
    // Path of application executable
    public static string BasePath { get; } = AppContext.BaseDirectory;

    // Supported Languages
    public static IEnumerable<CultureInfo> SupportedLanguages { get; } = HelperFunctions.GetAvailableCultures();

    // Dictionary of all supported modes
    public static Dictionary<string, IApplicationMode> Modes { get; set; } = new();

    // Dictionary of all available algorithms
    public static Dictionary<string, IHashAlgorithm> Algorithms { get; set; } = new();

    // Current Settings
    public static Settings Settings { get; set; } = Settings.Load();

    // Initialization function
    public static void Initialize()
    {
        // Set Culture for i18n
        Localization.Resources.Culture = CultureInfo.GetCultureInfo(Global.Settings.Language);

        // Use Reflection to get all classes in SumCompare.HashAlgorithms
        List<Type> algorithmTypes = Assembly.GetExecutingAssembly().GetTypes()
                            .Where(t => t.IsClass && t.Namespace == "SumCompare.HashAlgorithms")
                            .ToList();

        // Instantiate resulting Types and cast to Interface
        foreach (Type algorithmType in algorithmTypes)
        {
            IHashAlgorithm? hashAlgorithm = (IHashAlgorithm?)Activator.CreateInstance(algorithmType);
            if (hashAlgorithm is not null and IHashAlgorithm)
            {
                Algorithms.Add(hashAlgorithm.Name, hashAlgorithm);
            }
            else
            {
                throw new SumCompareException("Reflected object null or not child of IHashAlgorithm. This should never happen.");
            }
        }

        // Use Reflection to get all classes in SumCompare.ApplicationModes
        List<Type> applicationModeTypes = Assembly.GetExecutingAssembly().GetTypes()
                            .Where(t => t.IsClass && t.Namespace == "SumCompare.ApplicationModes")
                            .ToList();

        // Instantiate resulting Types and cast to Interface
        foreach (Type applicationModeType in applicationModeTypes)
        {
            IApplicationMode? applicationMode = (IApplicationMode?)Activator.CreateInstance(applicationModeType);
            if (applicationMode is not null and IApplicationMode)
            {
                Modes.Add(applicationMode.Name, applicationMode);
            }
            else
            {
                throw new SumCompareException("Reflected object null or not child of IApplicationMode. This should never happen.");
            }
        }
    }
}
