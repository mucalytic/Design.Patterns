using Design.Patterns.Bridge.Clothing.Interfaces;
using Design.Patterns.Bridge.Clothing.Items;

namespace Design.Patterns.Bridge.Clothing.Adapters;

public class ShoesClothingAdapter(Shoes shoes) : IClothingFormatter
{
    public string FormatTitle() =>
        $"{shoes.Brand} {shoes.Model}";

    public string FormatDescription() =>
        $"{shoes.Colour} {shoes.Brand} {shoes.Model} shoes ({shoes.Size})";

    public Uri FormatImageUrl() =>
        new($"https://clothing.com/shoes/{shoes.Brand.ToLower()}/{shoes.Model.ToLower()}/{shoes.Colour.ToLower()}.png");
}
