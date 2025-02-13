using Design.Patterns.Flyweight.Interfaces;
using System.Reactive;

namespace Design.Patterns.Flyweight.Concretions;

public class Flyweight(object intrinsicData) : IFlyweight
{
    public Unit Operation(object extrinsicData) => Unit.Default;
}
