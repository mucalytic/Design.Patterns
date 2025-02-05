using Design.Patterns.Decorator.Tesla.Components;
using FluentAssertions;

namespace Design.Patterns.Decorator.Tesla;

public class DecoratorTests
{
    [Fact]
    public void ConcreteComponentWritesItsName_WhenOperationIsCalled()
    {
        // arrange
        var component = new BasicTeslaModel3();

        // act
        var description = component.GetDescription();
        
        // assert
        description.Should().BeEmpty();
    }
}
