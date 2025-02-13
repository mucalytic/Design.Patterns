using Design.Patterns.Flyweight.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Flyweight.Factories;

public class FlyweightFactory(ITestOutputHelper helper)
{
    private readonly Dictionary<object, IFlyweight> _flyweights = new();
    
    public IFlyweight? GetFlyweight(object key) =>
        _flyweights.GetValueOrDefault(key);

    public void Add(object intrinsicData, IFlyweight flyweight)
    {
        if (_flyweights.TryAdd(intrinsicData, flyweight)) return;
        helper.WriteLine($"Flyweight with key {intrinsicData} is already added.");
    }
}
