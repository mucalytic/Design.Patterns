using Design.Patterns.Composite.University.Components;
using Xunit.Abstractions;
using FluentAssertions;
using NSubstitute;

namespace Design.Patterns.Composite.University;

public class CompositeTests
{
    [Fact]
    public void AllLeafOperationsAreRun_WhenRootOperationIsRun()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var leafA = new Course("Getting Started: Clean Architecture", TimeSpan.FromHours(3), 100m);
        var leafB = new Course("Deep Dive: Clean Architecture", TimeSpan.FromHours(4), 110m);
        var root = new Bundle(helper, "Zero to Hero: Clean Architecture");
        root.Add(leafA);
        root.Add(leafB);

        // act
        var duration = root.GetDuration();
        var price = root.GetPrice();

        // assert
        duration.Should().Be(TimeSpan.FromHours(7));
        price.Should().Be(168m);
    }
}
