using ReactiveUI;
using SumCompare.ViewModels;
using SumCompare.Views;
using SumCompare;
using System.Reactive;

namespace SumCompare.ViewModels;

public class SettingsViewModel : ViewModelBase
{
    public SettingsViewModel()
    {
        CancelSettingsWindow = ReactiveCommand.Create(_CancelSettingsWindow);
    }

    public ReactiveCommand<Unit, Unit> CancelSettingsWindow { get; }

    void _CancelSettingsWindow()
    {
        var settingsWindow = App.WindowDict["SettingsWindow"];
        settingsWindow.Close();
    }
}
