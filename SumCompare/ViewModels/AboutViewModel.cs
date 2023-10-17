using CommunityToolkit.Mvvm.Input;

namespace SumCompare.ViewModels;

public partial class AboutViewModel : ViewModelBase
{
    [RelayCommand]
    public void CloseAboutWindow()
    {
        var aboutWindow = WindowManager.Get("AboutWindow");
        aboutWindow.Close();
    }
}

