using Avalonia.Controls;

namespace SumCompare.Views;

public partial class AboutWindow : Window
{
    private static readonly string windowIdentifier = "AboutWindow";

    public AboutWindow()
    {
        InitializeComponent();
        App.WindowDict.Add(windowIdentifier, this);
        Closing += (sender, args) => App.WindowDict.Remove(windowIdentifier);
    }
}
