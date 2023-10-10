using CommunityToolkit.Mvvm.Input;
using SumCompare.Utilities;

namespace SumCompare.ViewModels;

public partial class AboutViewModel : ViewModelBase
{
    [RelayCommand]
    void CloseAboutWindow()
    {
        var aboutWindow = WindowManager.Get("AboutWindow");
        aboutWindow.Close();
    }
}

