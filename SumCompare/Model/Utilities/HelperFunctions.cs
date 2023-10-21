using SumCompare.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Security;

namespace SumCompare.Utilities;

public static class HelperFunctions
{
    // Enumerates all languages for which resource files are available
    public static IEnumerable<CultureInfo> GetAvailableCultures()
    {
        List<CultureInfo> result = new();

        ResourceManager rm = Resources.ResourceManager;

        CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
        foreach (CultureInfo culture in cultures)
        {
            try
            {
                if (culture.Equals(CultureInfo.InvariantCulture)) // Do not use "==", won't work
                {
                    continue; 
                }

                ResourceSet? rs = rm.GetResourceSet(culture, true, false);
                if (rs != null)
                {
                    result.Add(culture);
                }
            }
            catch (CultureNotFoundException)
            {
                //NOP
            }
        }
        return result;
    }

    // Sanitizes file paths (WIP)
    public static string GetFilePath(string path)
    {
        string filePath = "";

        // Get the full path
        try
        {
            filePath = Path.GetFullPath(path);
        }
        catch (Exception e) when (e is SecurityException || e is PathTooLongException)
        {
            throw new InvalidFilePath($"Path {filePath} is invalid.");
        }

        // Check if the path actually exists
        if (Path.Exists(filePath))
        {
            return filePath;
        }
        else
        {
            throw new InvalidFilePath($"Path {filePath} is invalid.");
        }
    }
}
