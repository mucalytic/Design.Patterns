using Design.Patterns.Decorator.Tesla.Interfaces;

namespace Design.Patterns.Decorator.Tesla.Components;

public class BasicTeslaModel3 : ITeslaModel3
{
    public string GetDescription() => string.Empty;

    public decimal GetPrice() => decimal.Zero;

    public int GetRange() => 0;
}
