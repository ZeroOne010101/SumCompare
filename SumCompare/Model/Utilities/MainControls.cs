using Avalonia.Controls;

namespace SumCompare.Utilities;
public abstract class MainControls
{
    public MainControls(UserControl topControl, UserControl bottomControl)
    {
        TopControl = topControl;
        BottomControl = bottomControl;
    }
    public UserControl TopControl { get; set; }
    public UserControl BottomControl { get; set; }
    public abstract string Name { get; }
    public abstract string ButtonText { get; }
}
