using SumCompare.ApplicationModes;
using SumCompare.Utilities;
using SumCompare.Views;
using System;
using System.Collections.Generic;

namespace SumCompare;

public static class State
{
    // Contains all cli arguments passed at runtime, the executable is in index 0
    private static readonly string[] commandLineArguments = Environment.GetCommandLineArgs();

    // Dictionary of all possible Modes
    public static Dictionary<string, MainControls> Modes { get; set; } = new()
    {
        {
            "HashFile", new HashFile( new FileView(commandLineArguments, 1), new ChecksumView() )
        },
        {
            "HashText", new HashText( new TextView(), new ChecksumView() )
        },
        {
            "CompareFiles",  new CompareFiles( new FileView(commandLineArguments, 1), new FileView(commandLineArguments, 2) )
        }
    };

    // Current Algorithm
    public static string CurrentAlgorithmStr { get; set; } = Configuration.Settings.DefaultAlgorithm;
    
    // Current Mode
    public static IHashAlgorithm CurrentAlgorithm
    {
        get { return HashGenerator.Algorithms[CurrentAlgorithmStr]; }
        set { CurrentAlgorithm = value; }
    }

    // Current Mode String
    public static string CurrentModeStr { get; set; } = Configuration.Settings.DefaultMode;

    // Current Mode
    public static MainControls CurrentMode
    {
        get { return Modes[CurrentModeStr]; }
        set { CurrentMode = value; }
    }
}
