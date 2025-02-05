using Design.Patterns.Decorator.Tesla.Interfaces;

namespace Design.Patterns.Decorator.Tesla.Decorators;

public class RedPaintTeslaDecorator(ITeslaModel3 car) : TeslaDecorator(car)
{
    public override string GetDescription() =>
        $"{base.GetDescription()}, Red Paint";

    public override decimal GetPrice() =>
        base.GetPrice() + 2_000m;
}
