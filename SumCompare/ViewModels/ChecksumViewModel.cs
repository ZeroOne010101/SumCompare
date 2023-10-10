using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace SumCompare.ViewModels;

public partial class ChecksumViewModel : ViewModelBase
{
    [ObservableProperty]
    private string checksum;

    [RelayCommand]
    public void CopyChecksum()
    {
        throw new NotImplementedException("Needs to be implemented first");
    }

    [RelayCommand]
    public void DeleteChecksum()
    {
        throw new NotImplementedException("Needs to be implemented first");
    }
}
