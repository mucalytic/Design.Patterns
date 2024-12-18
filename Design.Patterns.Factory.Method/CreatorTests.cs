using Design.Patterns.Factory.Method.Creators;
using Design.Patterns.Factory.Method.Products;
using FluentAssertions;

namespace Design.Patterns.Factory.Method;

public class CreatorTests
{
    [Fact]
    public void CreatorCreatesConcreteProduct()
    {
        // arrange
        Creator creator = new ConcreteCreator();
        
        // act
        Product product = creator.CreateProduct();

        // assert
        product.Should().BeOfType<ConcreteProduct>();
    }
}
