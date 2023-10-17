using Avalonia.Controls;
using SumCompare.Utilities;

namespace SumCompare.ApplicationModes;

public class CompareFiles : MainControls
{
    public CompareFiles(UserControl topControl, UserControl bottomControl) : base(topControl, bottomControl) { }
    public override string Name { get; } = "CompareFiles";
    public override string ButtonText { get; } = Localization.Resources.CompareFiles;
}
