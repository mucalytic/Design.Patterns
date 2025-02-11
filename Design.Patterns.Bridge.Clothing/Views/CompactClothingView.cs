using Design.Patterns.Bridge.Clothing.Abstractions;
using Design.Patterns.Bridge.Clothing.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Bridge.Clothing.Views;

public class CompactClothingView(
    ITestOutputHelper helper,
    IClothingFormatter clothingFormatter) :
    ClothingView(clothingFormatter)
{
    public override void Display()
    {
        helper.WriteLine(nameof(CompactClothingView));
        helper.WriteLine($"Title: {ClothingFormatter.FormatTitle()}");
    }
}
