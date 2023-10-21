using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace SumCompare.ViewModels;

public partial class FileViewModel : ViewModelBase
{
    public FileViewModel() { } // Necessary for the previewer to work
    public FileViewModel(int index)
    {
        try
        {
            filePath = Global.ArgumentList[index];
        }
        catch (IndexOutOfRangeException)
        {
            filePath = "";
        }
    }
    
    [ObservableProperty]
    private string filePath = "";

    [RelayCommand]
    public async Task OpenFileDialog()
    {
        var mainWindow = WindowManager.Get("MainWindow");
        var files = await mainWindow.StorageProvider.OpenFilePickerAsync(new Avalonia.Platform.Storage.FilePickerOpenOptions
        {
            Title = Localization.Resources.ChooseFile
        });

        if (files is not null)
        {
            Uri filePath = files[0].Path;
            FilePath = filePath.LocalPath.ToString();
        }
    }
}