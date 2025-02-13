using Design.Patterns.Flyweight.Factories;
using Design.Patterns.Flyweight.Clients;
using Design.Patterns.Flyweight.Models;
using Xunit.Abstractions;
using FluentAssertions;
using NSubstitute;

namespace Design.Patterns.Flyweight;

public class FlyweightTests
{
    [Fact]
    public void ClientUsesFactoryToGetFlyweightWithSpecifiedExtrinsicData_FromWhichTheOperationCanBeCalled()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var extrinsicState = new ExtrinsicState(Guid.NewGuid());
        var factory = new FlyweightFactory(helper);
        var client = new Client(factory);
        
        // act
        client.Operation(extrinsicState);
        client.Operation(extrinsicState);
        
        // assert
        helper.Received(2).WriteLine(Arg.Any<string>());
    }
}
