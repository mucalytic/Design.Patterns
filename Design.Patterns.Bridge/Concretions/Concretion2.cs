using Design.Patterns.Bridge.Abstractions;
using Design.Patterns.Bridge.Interfaces;

namespace Design.Patterns.Bridge.Concretions;

public class Concretion2(IImplementor implementor) : Abstraction(implementor)
{
    public override void Foo() => Implementor.Print();
}
