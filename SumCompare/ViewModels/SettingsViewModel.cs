using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SumCompare.Utilities;
using System;
using System.Collections.Generic;

namespace SumCompare.ViewModels;

public partial class SettingsViewModel : ViewModelBase
{
    /* Keeping it for posterity
    // TODO: Might not need to be observable
    private Settings observableSettings = Configuration.Settings;
    public Settings ObservableSettings
    {
        get => observableSettings;
        set
        {
            this.RaiseAndSetIfChanged(ref observableSettings, value);
            // Replace global object with modified object
            Configuration.Settings = observableSettings;
        }
    }*/

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
