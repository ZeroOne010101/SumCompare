using System.IO;
using System.Text.Json;

namespace SumCompare.Utilities
{
    public static class Configuration
    {
        const string configFile = "config.json";
        static readonly string basePath = System.AppContext.BaseDirectory;
        static readonly string configPath = Path.Combine(basePath, configFile);

        // Content of settings file
        public static Settings Settings {  get; set; } = new Settings();

        // TODO: Implement validation so other locations dont need to
        /*{
            get
            {
                // Fall back to first listed mode if configuration is invalid
                if (Modes.Keys.ToArray<string>().Contains(Settings.DefaultMode))
                {
                    return Settings.DefaultMode;
                }
                else
                {
                    return Modes.Keys.ToArray()[0];
                }
            }
            set { CurrentMode = value; }
        }*/
        public static void Load()
        {
            // Create config file, if it does not exist
            if (!File.Exists(configPath))
            {
                try
                {
                    Save();
                }
                catch
                {
                    throw new FileError("Could not save Configuration file.");
                }

            }

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

            // Deserialize into ConfigurationOptions
            try
            {
                Settings = JsonSerializer.Deserialize<Settings>(jsonString)!;
            }
            catch
            {
                throw new SumCompare.Utilities.InvalidFormat("The settings file could not be read.");
            }
        }

        public static void Save()
        {
            string jsonString = JsonSerializer.Serialize(Settings); // Serialize object into JSON format
            File.WriteAllText(configPath, jsonString); // (Over)write resulting json to file
        }
    }
}
