using Design.Patterns.Bridge.Interfaces;

namespace Design.Patterns.Bridge.Abstractions;

public abstract class Abstraction(IImplementor implementor)
{
    protected IImplementor Implementor { get; } = implementor;

    public abstract void Foo();
}
