using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace SumCompare.ViewModels;

public partial class TextViewModel : ViewModelBase
{
    [ObservableProperty]
    private string text = "";
}
