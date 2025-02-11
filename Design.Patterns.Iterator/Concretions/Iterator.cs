using Design.Patterns.Iterator.Interfaces;

namespace Design.Patterns.Iterator.Concretions;

public class Iterator<T> : IIterator<T>
{
    public bool HasNext()
    {
        throw new NotImplementedException();
    }

    public T Next()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}
