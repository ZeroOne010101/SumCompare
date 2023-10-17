using Avalonia.Controls;
using SumCompare.Utilities;

namespace SumCompare.ApplicationModes;

public class HashFile : MainControls
{
    public HashFile(UserControl topControl, UserControl bottomControl) : base(topControl, bottomControl) { }
    public override string Name { get; } = "HashFile";
    public override string ButtonText { get; } = Localization.Resources.HashFile;
}
