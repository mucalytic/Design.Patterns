using Design.Patterns.Bridge.Clothing.Abstractions;
using Design.Patterns.Bridge.Clothing.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Bridge.Clothing.Views;

public class DetailedClothingView(
    ITestOutputHelper helper,
    IClothingFormatter clothingFormatter) :
    ClothingView(clothingFormatter)
{
    public override void Display()
    {
        helper.WriteLine(nameof(DetailedClothingView));
        helper.WriteLine($"Image: {ClothingFormatter.FormatImageUrl()}");
        helper.WriteLine($"Title: {ClothingFormatter.FormatTitle()}");
        helper.WriteLine($"Description: {ClothingFormatter.FormatDescription()}");
    }
}
