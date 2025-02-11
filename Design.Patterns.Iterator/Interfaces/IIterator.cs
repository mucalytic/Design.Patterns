namespace Design.Patterns.Iterator.Interfaces;

public interface IIterator<out T>
{
    bool HasNext();
    T    Next();
    void Reset();
}
