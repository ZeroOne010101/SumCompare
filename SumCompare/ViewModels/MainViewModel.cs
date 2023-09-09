using Microsoft.CodeAnalysis.CSharp.Syntax;
using ReactiveUI;
using SumCompare.Utilities;
using SumCompare.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;

namespace SumCompare.ViewModels;

public class MainViewModel : ViewModelBase
{
    public List<string> AlgorithmItems { get; set; }
    public string SelectedAlgorithm { get; set; }

    public string InformationText => "Leer lassen um eine Checksum zu generieren.";

    public MainViewModel()
    {
        OpenAboutWindow = ReactiveCommand.Create(_OpenAboutWindow);
        OpenSettings = ReactiveCommand.Create(_OpenSettings);
        AlgorithmItems = HashGenerator.HashDict.Keys.ToList();
        SelectedAlgorithm = AlgorithmItems[0]; //TODO Set to Default Algorithm
        GenerateButton = ReactiveCommand.Create(_GenerateButton);
    }

    public ReactiveCommand<Unit, Unit> OpenAboutWindow { get; }
    public ReactiveCommand<Unit, Unit> OpenSettings { get; }
    public ReactiveCommand<Unit, Unit> GenerateButton {  get; }

    void _OpenAboutWindow()
    {
        var mainWindow = App.WindowDict["MainWindow"];
        var aboutWindow = new AboutWindow();
        aboutWindow.ShowDialog(mainWindow);
    }

    void _OpenSettings()
    {
        var mainWindow = App.WindowDict["MainWindow"];
        var settingsWindow = new SettingsWindow();
        settingsWindow.ShowDialog(mainWindow);
    }

    void _GenerateButton()
    {
        HashGenerator.GetTextHash("ABC", HashGenerator.HashDict[SelectedAlgorithm]); //TODO get text contents, diff between file and text, display/compare hash
    }
}
