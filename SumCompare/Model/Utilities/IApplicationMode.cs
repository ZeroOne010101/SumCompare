using Avalonia.Controls;

namespace SumCompare.Utilities;

public interface IApplicationMode
{
    public string Name { get; }
    public UserControl TopControl { get; set; }
    public UserControl BottomControl { get; set; }
    public string MainButtonText { get; }
    public void MainButtonCommand();
}
