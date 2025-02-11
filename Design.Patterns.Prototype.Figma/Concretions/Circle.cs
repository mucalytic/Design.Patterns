using Design.Patterns.Prototype.Figma.Interfaces;

namespace Design.Patterns.Prototype.Figma.Concretions;

public class Circle(int radius, Colour colour) : IPrototype<Circle>
{
    public Circle Clone() => new(radius, colour.Clone());
}
