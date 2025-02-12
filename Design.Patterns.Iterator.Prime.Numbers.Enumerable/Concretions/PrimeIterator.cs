using System.Collections;

namespace Design.Patterns.Iterator.Prime.Numbers.Enumerable.Concretions;

public class PrimeIterator(PrimeCollection primes) : IEnumerator<int>
{
    private int _itemsReturned;
    private int _current = 1;

    public int Current => _current;

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        if (_itemsReturned >= primes.Count) return false;
        while (!IsPrime(++_current));
        _itemsReturned++;
        return true;
    }

    public void Reset()
    {
        _current = 1;
        _itemsReturned = 0;
    }

    public void Dispose() { }

    private static bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        var sqrt = (int)Math.Sqrt(number);
        for (var i = 3; i <= sqrt; i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
