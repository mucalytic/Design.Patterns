using Design.Patterns.Iterator.Prime.Numbers.Interfaces;

namespace Design.Patterns.Iterator.Prime.Numbers.Concretions;

public class PrimeIterator : IPrimeIterator
{
    private PrimeCollection _primes;
    
    public bool HasNext()
    {
        throw new NotImplementedException();
    }

    public int Next()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}
