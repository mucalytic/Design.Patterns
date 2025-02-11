using Design.Patterns.Prototype.Interfaces;

namespace Design.Patterns.Prototype.Concretions;

public class Prototype : IPrototype
{
    public IPrototype Clone() => new Prototype();
}
