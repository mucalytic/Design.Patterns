using Design.Patterns.Decorator.Tesla.Interfaces;

namespace Design.Patterns.Decorator.Tesla.Decorators;

public class LongRangeTeslaDecorator(ITeslaModel3 car) : TeslaDecorator(car)
{
    public override string GetDescription() =>
        $"{base.GetDescription()}, Long-Range";

    public override decimal GetPrice() =>
        base.GetPrice() + 3_500m;

    public override int GetRange() =>
        base.GetRange() + 91;
}
