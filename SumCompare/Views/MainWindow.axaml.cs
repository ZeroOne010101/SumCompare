using Avalonia.Controls;

namespace SumCompare.Views;

public partial class MainWindow : Window
{
    private static readonly string windowIdentifier = "MainWindow";

    public MainWindow()
    {
        InitializeComponent();
        App.WindowDict.Add(windowIdentifier, this);
        Closing += (sender, args) => App.WindowDict.Remove(windowIdentifier);
    }
}
