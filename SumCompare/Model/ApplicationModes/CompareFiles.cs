using Avalonia.Controls;
using SumCompare.Utilities;

namespace SumCompare.ApplicationModes;

public class CompareFiles : IApplicationMode
{
    public string Name { get; } = "CompareFiles";
    public UserControl TopControl { get; set; } = new Views.FileView();
    public UserControl BottomControl { get; set; } = new Views.FileView();
    public string MainButtonText { get; } = Localization.Resources.CompareFiles;
    public void MainButtonCommand()
    {
    }
}
