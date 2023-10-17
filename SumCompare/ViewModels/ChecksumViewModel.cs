using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace SumCompare.ViewModels;

public partial class ChecksumViewModel : ViewModelBase
{
    [ObservableProperty]
    private string checksum = "";

    [RelayCommand]
    public async Task CopyChecksum()
    {
        var mainWindow = WindowManager.Get("MainWindow");
        var clipboard = mainWindow.Clipboard;
        if (clipboard != null)
        {
            await clipboard.SetTextAsync(Checksum);
        }
    }

    [RelayCommand]
    public void DeleteChecksum()
    {
        Checksum = "";
    }
}
