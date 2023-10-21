using Avalonia.Controls;
using SumCompare.Utilities;

namespace SumCompare.ApplicationModes;

public class HashText : IApplicationMode
{
    public string Name { get; } = "HashText";
    public UserControl TopControl { get; set; } = new Views.TextView();
    public UserControl BottomControl { get; set; } = new Views.ChecksumView();
    public string MainButtonText { get; } = Localization.Resources.HashText;
    public void MainButtonCommand()
    {
    }
}
