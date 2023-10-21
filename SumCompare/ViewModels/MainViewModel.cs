using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SumCompare.ApplicationModes;
using SumCompare.Utilities;
using SumCompare.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SumCompare.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private List<IApplicationMode> applicationModes = Global.Modes.Values.ToList();

    [ObservableProperty]
    private IApplicationMode selectedApplicationMode = Global.Modes[Global.Settings.DefaultMode];

    [ObservableProperty]
    private IApplicationMode currentApplicationMode = Global.Modes[Global.Settings.DefaultMode];

    [ObservableProperty]
    private List<IHashAlgorithm> hashAlgorithms = Global.Algorithms.Values.ToList();

    [ObservableProperty]
    private IHashAlgorithm selectedHashAlgorithm = Global.Algorithms[Global.Settings.DefaultAlgorithm];

    [ObservableProperty]
    private IHashAlgorithm currentHashAlgorithm = Global.Algorithms[Global.Settings.DefaultAlgorithm];

    [RelayCommand]
    public void SetApplicationMode()
    {
        CurrentApplicationMode = SelectedApplicationMode;
    }

    [RelayCommand]
    public void SetHashAlgorithm()
    {
        CurrentHashAlgorithm = SelectedHashAlgorithm;
    }

    [RelayCommand]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "RelayCommand requires the Method not to be static")]
    public void OpenAboutWindow()
    {
        var mainWindow = WindowManager.Get("MainWindow");
        var aboutWindow = new AboutWindow();
        aboutWindow.Show(mainWindow);
    }

    [RelayCommand]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "RelayCommand requires the Method not to be static")]
    public void OpenSettingsWindow()
    {
        var mainWindow = WindowManager.Get("MainWindow");
        var settingsWindow = new SettingsWindow();
        settingsWindow.ShowDialog(mainWindow);
    }

    [RelayCommand]
    public void MainButtonMethod()
    {
        CurrentApplicationMode.MainButtonCommand();
    }
}
