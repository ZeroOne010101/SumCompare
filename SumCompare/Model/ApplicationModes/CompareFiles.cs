using Avalonia.Controls;
using Microsoft.CodeAnalysis.Operations;
using SumCompare.Utilities;
using SumCompare.ViewModels;
using System;

namespace SumCompare.ApplicationModes;

public class CompareFiles : IApplicationMode
{
    public string Name { get; } = "CompareFiles";
    public UserControl TopControl { get; set; } = new Views.FileView(1);
    public UserControl BottomControl { get; set; } = new Views.FileView(2);
    public string MainButtonText { get; } = Localization.Resources.CompareFiles;
    public void MainButtonCommand()
    {
        var topViewModel = TopControl.DataContext as FileViewModel;
        var bottomViewModel = BottomControl.DataContext as FileViewModel;
        // Guard clause
        if (topViewModel is null || bottomViewModel is null) { return; }

        var topFile = HelperFunctions.GetFilePath(topViewModel.FilePath);
        var bottomFile = HelperFunctions.GetFilePath(bottomViewModel.FilePath);

        var mainWindow = WindowManager.Get("MainWindow");
        var mainViewModel = mainWindow.DataContext as MainViewModel;
        // Guard clause
        if (mainViewModel is null) { return; }
        var algorithm = mainViewModel.CurrentHashAlgorithm;

        var topHash = algorithm.FileHash(topFile);
        var bottomHash = algorithm.FileHash(bottomFile);
        if (topHash == bottomHash)
        {
            throw new NotImplementedException("ValidHash");
        }
        else
        {
            throw new NotImplementedException("InvalidHash");
        }
    }
}
