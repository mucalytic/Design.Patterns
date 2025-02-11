using Design.Patterns.Iterator.Prime.Numbers.Interfaces;

namespace Design.Patterns.Iterator.Prime.Numbers.Concretions;

public class PrimeCollection : IPrimeCollection
{
    public int Count { get; set; }
    
    public IPrimeIterator CreateIterator() =>
        new PrimeIterator();
}
