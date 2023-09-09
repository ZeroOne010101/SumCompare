using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Splat;
using SumCompare.Utilities;
using SumCompare.ViewModels;
using SumCompare.Views;
using System.Collections.Generic;
using System.Globalization;

namespace SumCompare;

public partial class App : Application
{
    // Dictionary to keep track of Window Objects
    public static Dictionary<string, Window> WindowDict = new();

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        // Initialize HashGenerator
        HashGenerator.Initialize();

        // Set Culture for i18n
        Assets.i18n.Resources.Culture = CultureInfo.CurrentUICulture;

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainViewModel()
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = new MainViewModel()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
