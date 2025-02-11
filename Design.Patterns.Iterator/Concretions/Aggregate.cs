using Design.Patterns.Iterator.Interfaces;

namespace Design.Patterns.Iterator.Concretions;

public class Aggregate<T> : IAggregate<T>
{
    private readonly List<T> _items = [];

    public int Count => _items.Count;
    
    public T GetItemAt(int index) => _items[index];
    
    public IIterator<T> CreateIterator() => new Iterator<T>(this);

    public void Add(T value) => _items.Add(value);
}
