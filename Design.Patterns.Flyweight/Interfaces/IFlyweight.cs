using System.Reactive;

namespace Design.Patterns.Flyweight.Interfaces;

public interface IFlyweight
{
    Unit Operation(object extrinsicData);
}
