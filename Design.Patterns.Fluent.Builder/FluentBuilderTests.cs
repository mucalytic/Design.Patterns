using Design.Patterns.Fluent.Builder.Models;
using FluentAssertions;

namespace Design.Patterns.Fluent.Builder;

public class FluentBuilderTests
{
    [Fact]
    public void ProductBuilder_ShouldProduceSimpleProduct()
    {
        // arrange
        var builder = new Product.Builder()
                                 .WithName("simple product")
                                 .WithDescription("simple product description");

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
        var builder = new Product.Builder()
                                 .WithName("complex product")
                                 .WithDescription("complex product description");

        // act
        var product = builder.Build();

        // assert
        product.Should().Match<Product>(p => p.Name == "complex product");
        product.Should().Match<Product>(p => p.Description == "complex product description");
    }
}
