namespace Design.Patterns.Bridge.Clothing.Interfaces;

public interface IClothingFormatter
{
    Uri    FormatImageUrl();
    string FormatTitle();
    string FormatDescription();
}
