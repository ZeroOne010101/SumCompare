using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;

namespace SumCompare.ViewModels;

public partial class SettingsViewModel : ViewModelBase
{
    [ObservableProperty]
    private List<string> algorithmItems;

    [ObservableProperty]
    private int selectedAlgorithmIndex;

    [ObservableProperty]
    private List<string> modeItems;

    [ObservableProperty]
    private int selectedModeIndex;

    [ObservableProperty]
    private List<string> languageItems;

    [ObservableProperty]
    private int selectedLanguageIndex;

    [RelayCommand]
    public void SaveSettings()
    {
        throw new NotImplementedException("needs translation to work i18nname => mode/algo/*name");
    }

    [RelayCommand]
    public void CloseSettingsWindow()
    {
        var settingsWindow = WindowManager.Get("SettingsWindow");
        settingsWindow.Close();
    }
}
