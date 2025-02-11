using Design.Patterns.Iterator.Interfaces;

namespace Design.Patterns.Iterator.Concretions;

public class Iterator<T>(Aggregate<T> aggregate) : IIterator<T>
{
    private int _index = -1;
    
    public bool HasNext() =>
        _index < aggregate.Count - 1;

    public T Next()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException();
        }
        _index++;
        return aggregate.GetItemAt(_index);
    }

    public void Reset() =>
        _index = -1;
}
