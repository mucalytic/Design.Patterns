using Design.Patterns.Decorator.Tesla.Interfaces;

namespace Design.Patterns.Decorator.Tesla.Decorators;

public abstract class TeslaDecorator(ITeslaModel3 car) : ITeslaModel3
{
    protected readonly ITeslaModel3 _car = car;
    
    public virtual string GetDescription() => _car.GetDescription();
    public virtual decimal GetPrice() => _car.GetPrice();
    public virtual int GetRange() => _car.GetRange();
}
