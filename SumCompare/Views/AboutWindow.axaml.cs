using Avalonia.Controls;
using SumCompare.Utilities;

namespace SumCompare.Views;

public partial class AboutWindow : Window
{
    private const string windowIdentifier = "AboutWindow";

    public AboutWindow()
    {
        InitializeComponent();
        WindowManager.Add(windowIdentifier, this);
        Closing += (sender, args) => WindowManager.Remove(windowIdentifier);
    }
}
