using Design.Patterns.Bridge.Clothing.Interfaces;

namespace Design.Patterns.Bridge.Clothing.Abstractions;

public abstract class ClothingView
{
    private IClothingFormatter _clothingFormatter;

    public void Display() { }
}
