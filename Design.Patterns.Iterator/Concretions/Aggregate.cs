using Design.Patterns.Iterator.Interfaces;

namespace Design.Patterns.Iterator.Concretions;

public class Aggregate<T> : IAggregate<T>
{
    public IIterator<T> CreateIterator() => new Iterator<T>();
}
