using Design.Patterns.Iterator.Prime.Numbers.Enumerable.Concretions;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Iterator.Prime.Numbers.Enumerable;

public class IteratorTests
{
    [Fact]
    public void Enumerator_ShouldReturnPrimeNumbers_ForCountSpecifiedInPrimeCollection()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var primes = new PrimeCollection(10);
        using var enumerator = primes.GetEnumerator();

        // act
        foreach (var prime in primes)
        {
            helper.WriteLine(prime.ToString());
        }
        enumerator.Reset();
        foreach (var prime in primes)
        {
            helper.WriteLine(prime.ToString());
        }
        
        // assert
        helper.Received(2).WriteLine("2");
        helper.Received(2).WriteLine("3");
        helper.Received(2).WriteLine("5");
        helper.Received(2).WriteLine("7");
        helper.Received(2).WriteLine("11");
        helper.Received(2).WriteLine("13");
        helper.Received(2).WriteLine("17");
        helper.Received(2).WriteLine("19");
        helper.Received(2).WriteLine("23");
        helper.Received(2).WriteLine("29");
    }
}
