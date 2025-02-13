using Design.Patterns.Flyweight.Factories;
using Design.Patterns.Flyweight.Clients;
using Xunit.Abstractions;
using FluentAssertions;
using System.Reactive;
using NSubstitute;

namespace Design.Patterns.Flyweight;

public class FlyweightTests
{
    [Fact]
    public void ClientUsesFactoryToGetFlyweightWithSpecifiedExtrinsicData_FromWhichTheOperationCanBeCalled()
    {
        // arrange
        var intrinsicData = new object();
        var extrinsicData = new object();
        var flyweight = new Concretions.Flyweight(intrinsicData);
        var helper = Substitute.For<ITestOutputHelper>();
        var factory = new FlyweightFactory(helper);
        factory.Add(intrinsicData, flyweight);
        var client = new Client(factory);

        // act
        var result = client.Operation(extrinsicData);

        // assert
        result.Should().Be(Unit.Default);
    }
}
