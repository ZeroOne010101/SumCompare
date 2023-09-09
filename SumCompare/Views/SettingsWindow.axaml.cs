using Avalonia.Controls;

namespace SumCompare.Views;

public partial class SettingsWindow : Window
{
    private static readonly string windowIdentifier = "SettingsWindow";

    public SettingsWindow()
    {
        InitializeComponent();
        App.WindowDict.Add(windowIdentifier, this);
        Closing += (sender, args) => App.WindowDict.Remove(windowIdentifier);
    }
}
