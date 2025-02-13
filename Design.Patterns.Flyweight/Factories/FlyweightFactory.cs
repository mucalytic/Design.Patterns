using Design.Patterns.Flyweight.Interfaces;
using Design.Patterns.Flyweight.Models;
using Xunit.Abstractions;

namespace Design.Patterns.Flyweight.Factories;

public class FlyweightFactory(ITestOutputHelper helper)
{
    private readonly Dictionary<Guid, IFlyweight> _flyweights = new();

    public IFlyweight GetFlyweight(Guid key)
    {
        if (_flyweights.TryGetValue(key, out var flyweight)) return flyweight;
        flyweight = new Concretions.Flyweight(helper, new IntrinsicState(key));
        _flyweights[key] = flyweight;
        return flyweight;
    }
}
