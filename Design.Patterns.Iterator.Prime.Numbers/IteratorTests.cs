using Design.Patterns.Iterator.Prime.Numbers.Concretions;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Iterator.Prime.Numbers;

public class IteratorTests
{
    [Fact]
    public void Iterator_ShouldReturnPrimeNumbers_ForCountSpecifiedInPrimeCollection()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var primes = new PrimeCollection(10);
        var iterator = primes.CreateIterator();

        // act
        while (iterator.HasNext())
        {
            helper.WriteLine(iterator.Next().ToString());
        }
        iterator.Reset();
        while (iterator.HasNext())
        {
            helper.WriteLine(iterator.Next().ToString());
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
