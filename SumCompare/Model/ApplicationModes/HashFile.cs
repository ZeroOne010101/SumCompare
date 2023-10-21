using Avalonia.Controls;
using SumCompare.Utilities;

namespace SumCompare.ApplicationModes;

public class HashFile : IApplicationMode
{
    public string Name { get; } = "HashFile";
    public UserControl TopControl { get; set; } = new Views.FileView();
    public UserControl BottomControl { get; set; } = new Views.ChecksumView();
    public string MainButtonText { get; } = Localization.Resources.HashFile;
    public void MainButtonCommand()
    {
    }
}
