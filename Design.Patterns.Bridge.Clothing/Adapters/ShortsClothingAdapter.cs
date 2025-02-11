using Design.Patterns.Bridge.Clothing.Interfaces;
using Design.Patterns.Bridge.Clothing.Items;

namespace Design.Patterns.Bridge.Clothing.Adapters;

public class ShortsClothingAdapter(Shorts shorts) : IClothingFormatter
{
    public Uri FormatImageUrl()
    {
        throw new NotImplementedException();
    }

    public string FormatTitle()
    {
        throw new NotImplementedException();
    }

    public string FormatDescription()
    {
        throw new NotImplementedException();
    }
}
