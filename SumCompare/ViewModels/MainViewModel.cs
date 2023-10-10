using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SumCompare.Utilities;
using SumCompare.Views;
using System;
using System.Collections.Generic;

namespace SumCompare.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private List<string> algorithmItems;

    [ObservableProperty]
    public int selectedAlgorithmIndex;

    [ObservableProperty]
    private List<string> modeItems;

    [ObservableProperty]
    public int selectedModeIndex;

    [RelayCommand]
    public void OpenAboutWindow()
    {
        var mainWindow = WindowManager.Get("MainWindow");
        var aboutWindow = new AboutWindow();
        aboutWindow.Show(mainWindow);
    }

    [RelayCommand]
    public void OpenSettingsWindow()
    {
        var mainWindow = WindowManager.Get("MainWindow");
        var settingsWindow = new SettingsWindow();
        settingsWindow.ShowDialog(mainWindow);
    }

    [RelayCommand]
    public void MainButtonMethod()
    {
        throw new NotImplementedException("Not implemented yet, the main controls need to work first");
    }
}
