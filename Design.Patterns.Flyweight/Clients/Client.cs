using Design.Patterns.Flyweight.Factories;
using Design.Patterns.Flyweight.Models;

namespace Design.Patterns.Flyweight.Clients;

public class Client(FlyweightFactory factory)
{
    public void Operation(ExtrinsicState extrinsicState) =>
        factory.GetFlyweight(extrinsicState.Value).Operation(extrinsicState);
}
