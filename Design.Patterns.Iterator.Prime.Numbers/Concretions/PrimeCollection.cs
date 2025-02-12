using Design.Patterns.Iterator.Prime.Numbers.Interfaces;

namespace Design.Patterns.Iterator.Prime.Numbers.Concretions;

public class PrimeCollection(int count) : IPrimeCollection
{
    public int Count { get; } = count;
    
    public IPrimeIterator CreateIterator() =>
        new PrimeIterator(this);
}
