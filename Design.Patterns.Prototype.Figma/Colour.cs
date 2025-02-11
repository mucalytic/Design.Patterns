using Design.Patterns.Prototype.Figma.Interfaces;

namespace Design.Patterns.Prototype.Figma;

public class Colour(ushort red, ushort green, ushort blue) : IPrototype<Colour>
{
    public static readonly Colour Red   = new(255, 0, 0);
    public static readonly Colour Green = new(0, 255, 0);
    public static readonly Colour Blue  = new(0, 0, 255);

    public Colour Clone() => new(red, green, blue);
}
