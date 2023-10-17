using Avalonia.Controls;

namespace SumCompare.Views;

public partial class SettingsWindow : Window
{
    private const string windowIdentifier = "SettingsWindow";

    public SettingsWindow()
    {
        InitializeComponent();
        WindowManager.Add(windowIdentifier, this);
        Closing += (sender, args) => WindowManager.Remove(windowIdentifier);
    }
}
