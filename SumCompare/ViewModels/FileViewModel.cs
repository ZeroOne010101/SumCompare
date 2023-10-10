using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace SumCompare.ViewModels;

public partial class FileViewModel : ViewModelBase
{
    [ObservableProperty]
    private string filePath;

    [RelayCommand]
    public void OpenFileDialog()
    {
        throw new NotImplementedException("File dialog needs to be implemented first");
    }
}