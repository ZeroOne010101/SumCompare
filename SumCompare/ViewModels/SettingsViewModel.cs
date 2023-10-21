using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SumCompare.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SumCompare.ViewModels;

public partial class SettingsViewModel : ViewModelBase
{
    [ObservableProperty]
    private List<IApplicationMode> applicationModes = Global.Modes.Values.ToList();

    [ObservableProperty]
    private IApplicationMode selectedApplicationMode = Global.Modes[Global.Settings.DefaultMode];

    [ObservableProperty]
    private List<IHashAlgorithm> hashAlgorithms = Global.Algorithms.Values.ToList();

    [ObservableProperty]
    private IHashAlgorithm selectedHashAlgorithm = Global.Algorithms[Global.Settings.DefaultAlgorithm];

    [ObservableProperty]
    private List<CultureInfo> languages = Global.SupportedLanguages.ToList();

    [ObservableProperty]
    private CultureInfo selectedLanguage = Localization.Resources.Culture;

    [RelayCommand]
    public void SaveSettings()
    {
        // Instanciate new settings and replace existing ones, then save
        Settings newSettings = new(SelectedHashAlgorithm.Name, SelectedApplicationMode.Name, SelectedLanguage.Name, Global.Settings.LogLevel);
        Global.Settings = newSettings;
        Global.Settings.Save();
        
        // Close Window
        var settingsWindow = WindowManager.Get("SettingsWindow");
        settingsWindow.Close();
    }

    [RelayCommand]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "RelayCommand requires the Method not to be static")]
    public void CloseSettingsWindow()
    {
        var settingsWindow = WindowManager.Get("SettingsWindow");
        settingsWindow.Close();
    }
}
