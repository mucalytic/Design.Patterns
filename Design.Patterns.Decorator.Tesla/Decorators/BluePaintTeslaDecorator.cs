using Design.Patterns.Decorator.Tesla.Interfaces;

namespace Design.Patterns.Decorator.Tesla.Decorators;

public class BluePaintTeslaDecorator(ITeslaModel3 car) : TeslaDecorator(car)
{
    public override string GetDescription() =>
        $"{base.GetDescription()}, Blue Paint";

    public override decimal GetPrice() =>
        base.GetPrice() + 1_000m;
}
