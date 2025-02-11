using Design.Patterns.Bridge.Clothing.Interfaces;

namespace Design.Patterns.Bridge.Clothing.Abstractions;

public abstract class ClothingView(IClothingFormatter clothingFormatter)
{
    protected IClothingFormatter ClothingFormatter { get; } = clothingFormatter;

    public abstract void Display();
}
