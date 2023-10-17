using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SumCompare.ApplicationModes;
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

    [ObservableProperty]
    public UserControl topControl = State.CurrentMode.TopControl;

    [ObservableProperty]
    public UserControl bottomControl = State.CurrentMode.BottomControl;

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

    [ObservableProperty]
    // Manual implementation of ObservableProperty due to custom get
    public string mainButtonContent = State.CurrentMode.ButtonText;

    [RelayCommand]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "RelayCommand requires the Method not to be static")]
    public void MainButtonMethod()
    {
        switch (State.CurrentMode)
        {
            case var _ when State.CurrentMode.GetType() == typeof(CompareFiles):
                FileViewModel topViewModel = (FileViewModel)State.CurrentMode.TopControl.DataContext!;
                FileViewModel bottomViewModel = (FileViewModel)State.CurrentMode.BottomControl.DataContext!;
                string firstHash = HashGenerator.GetFileHash(topViewModel.FilePath, State.CurrentAlgorithm);
                string secondHash = HashGenerator.GetFileHash(bottomViewModel.FilePath, State.CurrentAlgorithm);
                if (firstHash == secondHash)
                {
                    // There has to be a better way for this
                }
                break;
            case var _ when State.CurrentMode.GetType() == typeof(HashFile):
                break;
            case var _ when State.CurrentMode.GetType() == typeof(HashText):
                break;
            default:
                break;
        }
    }
}
