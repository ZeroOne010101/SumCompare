using SumCompare.Views;
using System;
using System.Collections.Generic;
using System.Linq;

}
namespace SumCompare.Utilities
{
    public static class State
    {
        // Dictionary of all possible Modes
        public static Dictionary<string, MainControls> Modes { get; set; } = new()
        {
            { "HashFile",       new MainControls(new FileView(), new ChecksumView()) },
            { "HashText",       new MainControls(new TextView(), new ChecksumView()) },
            { "CompareFiles",   new MainControls(new FileView(), new FileView())     }
        };

        // Current Algorithm
        public static string CurrentAlgorithm { get; set; } = Configuration.Settings.DefaultAlgorithm;

        // Current Mode
        public static string CurrentMode { get; set; } = Configuration.Settings.DefaultMode;
    }
}
