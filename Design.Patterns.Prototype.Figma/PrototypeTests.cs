using FluentAssertions;

namespace Design.Patterns.Prototype.Figma;

public class PrototypeTests
{
    [Fact]
    public void ClonedObject_ShouldBeSameTypeAsOriginalObject_ButNotTheSameObject()
    {
        // arrange
        var circle = new Concretions.Circle(100, Colour.Blue);
        var rectangle = new Concretions.Rectangle(100, 100, Colour.Red);

        // act
        var circleClone = circle.Clone();
        var rectangleClone = rectangle.Clone();
        
        // assert
        circleClone.Should().NotBeNull();
        circleClone.Should().NotBeSameAs(circle);
        circleClone.Should().BeOfType<Concretions.Circle>();

        rectangleClone.Should().NotBeNull();
        rectangleClone.Should().NotBeSameAs(rectangle);
        rectangleClone.Should().BeOfType<Concretions.Rectangle>();
    }
}
