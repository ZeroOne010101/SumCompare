using CommunityToolkit.Mvvm.ComponentModel;

namespace SumCompare.ViewModels;

public partial class TextViewModel : ViewModelBase
{
    [ObservableProperty]
    private string text;
}
