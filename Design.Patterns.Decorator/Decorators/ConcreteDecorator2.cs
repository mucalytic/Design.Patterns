using Design.Patterns.Decorator.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Decorator.Decorators;

public class ConcreteDecorator2(ITestOutputHelper helper, IComponent component) : AbstractDecorator(component)
{
    public override void Operation()
    {
        helper.WriteLine($"-------- {nameof(ConcreteDecorator2)} --------");
        component.Operation();
        helper.WriteLine($"-------- {nameof(ConcreteDecorator2)} --------");
    }
}
