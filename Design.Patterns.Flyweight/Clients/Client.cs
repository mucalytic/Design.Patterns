using Design.Patterns.Flyweight.Factories;
using System.Reactive;

namespace Design.Patterns.Flyweight.Clients;

public class Client(FlyweightFactory factory)
{
    public Unit Operation(object extrinsicData)
    {
        var flyweight = factory.GetFlyweight(extrinsicData);
        return flyweight?.Operation(extrinsicData) ?? Unit.Default;
    }
}
