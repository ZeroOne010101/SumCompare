using Avalonia.Controls;
using SumCompare.Utilities;
using SumCompare.ViewModels;
using System;

namespace SumCompare.ApplicationModes;

public class HashText : IApplicationMode
{
    public string Name { get; } = "HashText";
    public UserControl TopControl { get; set; } = new Views.TextView();
    public UserControl BottomControl { get; set; } = new Views.ChecksumView();
    public string MainButtonText { get; } = Localization.Resources.HashText;
    public void MainButtonCommand()
    {
        var topViewModel = TopControl.DataContext as TextViewModel;
        var bottomViewModel = BottomControl.DataContext as ChecksumViewModel;
        // Guard clause
        if (topViewModel is null || bottomViewModel is null) { return; }

        var topText = topViewModel.Text;
        var bottomChecksum = bottomViewModel.Checksum;

        var mainWindow = WindowManager.Get("MainWindow");
        var mainViewModel = mainWindow.DataContext as MainViewModel;
        // Guard clause
        if (mainViewModel is null) { return; }
        var algorithm = mainViewModel.CurrentHashAlgorithm;

        var topHash = algorithm.TextHash(topText);
        if (bottomChecksum is "")
        {
            bottomViewModel.Checksum = topHash;
        }
        else if (topHash == bottomChecksum)
        {
            throw new NotImplementedException("ValidHash");
        }
        else
        {
            throw new NotImplementedException("InvalidHash");
        }
    }
}
