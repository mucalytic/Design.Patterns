using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Composite;

public class CompositeTests
{
    [Fact]
    public void AllLeafOperationsAreRun_WhenRootOperationIsRun()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var child = new Composite(helper);
        var leafB = new Leaf(helper);
        var leafC = new Leaf(helper);
        child.Add(leafB);
        child.Add(leafC);
        var root = new Composite(helper);
        var leafA = new Leaf(helper);
        root.Add(leafA);
        root.Add(child);

        // act
        root.Operation();

        // assert
        helper.Received(3).WriteLine($"{nameof(Leaf)}.{nameof(Leaf.Operation)}");
    }
}
