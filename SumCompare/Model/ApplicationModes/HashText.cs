using Avalonia.Controls;
using SumCompare.Utilities;

namespace SumCompare.ApplicationModes;

public class HashText : MainControls
{
    public HashText(UserControl topControl, UserControl bottomControl) : base(topControl, bottomControl) { }
    public override string Name { get; } = "HashText";
    public override string ButtonText { get; } = Localization.Resources.HashText;
}
