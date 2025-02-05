using Design.Patterns.Decorator.Interfaces;

namespace Design.Patterns.Decorator.Decorators;

public abstract class AbstractDecorator(IComponent component) : IComponent
{
    public virtual void Operation() => component.Operation();
}
