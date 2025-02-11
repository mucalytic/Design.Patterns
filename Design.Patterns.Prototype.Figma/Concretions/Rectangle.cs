using Design.Patterns.Prototype.Figma.Interfaces;

namespace Design.Patterns.Prototype.Figma.Concretions;

public class Rectangle(int width, int height, Colour colour) : IPrototype<Rectangle>
{
    public Rectangle Clone() => new(width, height, colour.Clone());
}
