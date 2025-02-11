namespace Design.Patterns.Iterator.Interfaces;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
    void         Add(T value);
}
