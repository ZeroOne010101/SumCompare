using SumCompare.Utilities;
using System.IO;
using System.Text.Json;

namespace SumCompare;

public class Settings
{
    // Constants
    private const string configFile = "config.json";
    static readonly string configPath = Path.Combine(Global.BasePath, configFile);

    // Empty default constructor
    public Settings()
    {
    }

    // Manual constructor
    public Settings(string defaultAlgorithm, string defaultMode, string language, string logLevel)
    {
        DefaultAlgorithm = defaultAlgorithm;
        DefaultMode = defaultMode;
        Language = language;
        LogLevel = logLevel;
    }

    // File constructor
    public static Settings Load()
    {
        // Create config file, if it does not exist
        if (!File.Exists(configPath))
        {
            return new Settings();
        }
        else
        {
            string jsonString;

            // Load Config file
            try
            {
                jsonString = File.ReadAllText(configPath);
            }
            catch
            {
                throw new FileError($"The file {configPath} could not be read.");
            }

            // Deserialize into Settings
            try
            {
                return JsonSerializer.Deserialize<Settings>(jsonString)!; // Possibility of null value handled through default property assignments
            }
            catch
            {
                throw new InvalidFormat("The settings file could not be read.");
            }
        }
    }

    // Save config file
    public void Save()
    {
        string jsonString = JsonSerializer.Serialize(this); // Serialize object into JSON format
        File.WriteAllText(configPath, jsonString); // (Over)write resulting json to file
    }

    // Deserializable properties
    public string DefaultAlgorithm { get; set; } = "MD5";
    public string DefaultMode { get; set; } = "HashFile";
    public string Language { get; set; } = System.Globalization.CultureInfo.CurrentCulture.Name;
    public string LogLevel { get; set; } = "Warning";
}
