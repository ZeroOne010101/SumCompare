using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace SumCompare.ViewModels;

public partial class FileViewModel : ViewModelBase
{
    public FileViewModel() { } // Necessary for the previewer to work
    public FileViewModel(string[] arguments, int index)
    {
        try
        {
            filePath = arguments[index];
        }
        catch (IndexOutOfRangeException)
        {
            filePath = "";
        }
    }
    
    [ObservableProperty]
    private string filePath = "";

    [RelayCommand]
    public void OpenFileDialog()
    {
        throw new NotImplementedException("File dialog needs to be implemented first");
    }
}