using Design.Patterns.Decorator.Tesla.Interfaces;

namespace Design.Patterns.Decorator.Tesla.Decorators;

public abstract class TeslaDecorator(ITeslaModel3 teslaModel3) : ITeslaModel3
{
    public virtual string GetDescription() => teslaModel3.GetDescription();
    public virtual decimal GetPrice() => teslaModel3.GetPrice();
    public virtual int GetRange() => teslaModel3.GetRange();
}
