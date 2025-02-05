using Design.Patterns.Decorator.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Decorator.Components;

public class ConcreteComponent(ITestOutputHelper helper) : IComponent
{
    public void Operation() =>
        helper.WriteLine(nameof(ConcreteComponent));
}
