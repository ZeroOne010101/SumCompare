using Avalonia.Controls;
using SumCompare.Utilities;
using SumCompare.ViewModels;
using System;

namespace SumCompare.ApplicationModes;

public class HashFile : IApplicationMode
{
    public string Name { get; } = "HashFile";
    public UserControl TopControl { get; set; } = new Views.FileView(1);
    public UserControl BottomControl { get; set; } = new Views.ChecksumView();
    public string MainButtonText { get; } = Localization.Resources.HashFile;
    public void MainButtonCommand()
    {
        var topViewModel = TopControl.DataContext as FileViewModel;
        var bottomViewModel = BottomControl.DataContext as ChecksumViewModel;
        // Guard clause
        if (topViewModel is null || bottomViewModel is null) { return; }

        var topFile = HelperFunctions.GetFilePath(topViewModel.FilePath);
        var bottomChecksum = bottomViewModel.Checksum;

        var mainWindow = WindowManager.Get("MainWindow");
        var mainViewModel = mainWindow.DataContext as MainViewModel;
        // Guard clause
        if (mainViewModel is null) { return; }
        var algorithm = mainViewModel.CurrentHashAlgorithm;

        var topHash = algorithm.FileHash(topFile);
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
