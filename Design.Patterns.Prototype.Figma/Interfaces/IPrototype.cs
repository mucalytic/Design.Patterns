namespace Design.Patterns.Prototype.Figma.Interfaces;

public interface IPrototype<out T>
{
    T Clone();
}
