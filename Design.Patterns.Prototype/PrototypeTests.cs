using FluentAssertions;

namespace Design.Patterns.Prototype;

public class PrototypeTests
{
    [Fact]
    public void ClonedObject_ShouldBeSameTypeAsOriginalObject_ButNotTheSameObject()
    {
        // arrange
        var prototype = new Concretions.Prototype();

        // act
        var clone = prototype.Clone();
        
        // assert
        clone.Should().NotBeNull();
        clone.Should().NotBeSameAs(prototype);
        clone.Should().BeOfType<Concretions.Prototype>();
    }
}
