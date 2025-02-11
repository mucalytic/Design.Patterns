using Design.Patterns.Iterator.Concretions;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Iterator;

public class IteratorTests
{
    [Fact]
    public void Iterator_ShouldReturnAllItems_WhileItemsRemain()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var aggregate = new Aggregate<int>();
        var iterator = aggregate.CreateIterator();

        aggregate.Add(1);
        aggregate.Add(2);
        aggregate.Add(3);
        
        // act
        while (iterator.HasNext())
        {
            helper.WriteLine(iterator.Next().ToString());
        }
        
        // assert
        helper.Received(1).WriteLine("1");
        helper.Received(1).WriteLine("2");
        helper.Received(1).WriteLine("3");
    }
}
