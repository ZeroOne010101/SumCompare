using Avalonia.Controls;

namespace SumCompare.Views;

public partial class MainWindow : Window
{
    private const string windowIdentifier = "MainWindow";

    public MainWindow()
    {
        InitializeComponent();
        WindowManager.Add(windowIdentifier, this);
        Closing += (sender, args) => WindowManager.Remove(windowIdentifier);
    }
}
