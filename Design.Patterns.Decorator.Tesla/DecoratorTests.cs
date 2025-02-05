using Design.Patterns.Decorator.Tesla.Components;
using Design.Patterns.Decorator.Tesla.Decorators;
using FluentAssertions;

namespace Design.Patterns.Decorator.Tesla;

public class DecoratorTests
{
    [Fact]
    public void BasicTesla_ShouldHaveCorrespondingValues()
    {
        // arrange
        var car = new BasicTeslaModel3();

        // act
        var description = car.GetDescription();
        var price = car.GetPrice();
        var range = car.GetRange();
        
        // assert
        description.Should().Be("Tesla Model 3 Rear-Wheel Drive");
        price.Should().Be(38_990m);
        range.Should().Be(272);
    }

    [Fact]
    public void RedPaintLongRangeTesla_ShouldHaveCorrespondingValues()
    {
        // arrange
        var car = new RedPaintTeslaDecorator(new LongRangeTeslaDecorator(new BasicTeslaModel3()));

        // act
        var description = car.GetDescription();
        var price = car.GetPrice();
        var range = car.GetRange();
        
        // assert
        description.Should().Be("Tesla Model 3 Rear-Wheel Drive, Long-Range, Red Paint");
        price.Should().Be(44_490m);
        range.Should().Be(363);
    }
}
