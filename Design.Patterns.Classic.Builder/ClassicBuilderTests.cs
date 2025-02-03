using Design.Patterns.Classic.Builder.Directors;
using Design.Patterns.Classic.Builder.Builders;
using Design.Patterns.Classic.Builder.Models;
using FluentAssertions;

namespace Design.Patterns.Classic.Builder;

public class ClassicBuilderTests
{
    [Fact]
    public void SimpleProductBuilder_ShouldProduceSimpleProduct()
    {
        // arrange
        var builder = new SimpleProductBuilder();
        var director = new ProductDirector(builder);

        // act
        director.ConstructProduct();
        var product = builder.Build();

        // assert
        product.Should().Match<Product>(p => p.Name == "simple product");
        product.Should().Match<Product>(p => p.Description == "simple product description");
    }

    [Fact]
    public void ComplexProductBuilder_ShouldProduceComplexProduct()
    {
        // arrange
        var builder = new ComplexProductBuilder();
        var director = new ProductDirector(builder);

        // act
        director.ConstructProduct();
        var product = builder.Build();

        // assert
        product.Should().Match<Product>(p => p.Name == "complex product");
        product.Should().Match<Product>(p => p.Description == "complex product description");
    }
}
