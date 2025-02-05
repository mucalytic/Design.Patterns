using Design.Patterns.Decorator.Tesla.Interfaces;

namespace Design.Patterns.Decorator.Tesla.Components;

public class BasicTeslaModel3 : ITeslaModel3
{
    public string GetDescription() => "Tesla Model 3 Rear-Wheel Drive";

    public decimal GetPrice() => 38_990m;

    public int GetRange() => 272;
}
