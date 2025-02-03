using Design.Patterns.Nested.Builder.Models;
using FluentAssertions;

namespace Design.Patterns.Nested.Builder;

public class NestedBuilderTests
{
    [Fact]
    public void ProductBuilder_ShouldProduceSimpleProduct()
    {
        // arrange
        var builder = new Product.Builder();
        builder.BuildName("simple product");
        builder.BuildDescription("simple product description");

        // act
        var product = builder.Build();

        // assert
        product.Should().Match<Product>(p => p.Name == "simple product");
        product.Should().Match<Product>(p => p.Description == "simple product description");
    }
    
    [Fact]
    public void ProductBuilder_ShouldProduceComplexProduct()
    {
        // arrange
        var builder = new Product.Builder();
        builder.BuildName("complex product");
        builder.BuildDescription("complex product description");

        // act
        var product = builder.Build();

        // assert
        product.Should().Match<Product>(p => p.Name == "complex product");
        product.Should().Match<Product>(p => p.Description == "complex product description");
    }
}
