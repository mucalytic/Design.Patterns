namespace Design.Patterns.Iterator.Interfaces;

public interface IAggregate<out T>
{
    IIterator<T> CreateIterator();
}
