using Avalonia.Controls;

public class MainControls
{
    public MainControls(UserControl topControl, UserControl bottomControl)
    {
        TopControl = topControl;
        BottomControl = bottomControl;
    }
    public UserControl TopControl { get; set; }
    public UserControl BottomControl { get; set; }
}
