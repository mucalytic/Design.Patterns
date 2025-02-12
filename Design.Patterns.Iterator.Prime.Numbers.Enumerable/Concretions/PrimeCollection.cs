using System.Collections;

namespace Design.Patterns.Iterator.Prime.Numbers.Enumerable.Concretions;

public class PrimeCollection(int count) : IEnumerable<int>
{
    public int Count { get; } = count;

    public IEnumerator<int> GetEnumerator() =>
        new PrimeIterator(this);

    IEnumerator IEnumerable.GetEnumerator() =>
        GetEnumerator();
}
