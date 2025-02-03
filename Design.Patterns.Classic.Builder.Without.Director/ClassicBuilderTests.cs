using Design.Patterns.Classic.Builder.Without.Director.Builders;
using Design.Patterns.Classic.Builder.Without.Director.Models;
using FluentAssertions;

namespace Design.Patterns.Classic.Builder.Without.Director;

public class ClassicBuilderTests
{
    [Fact]
    public void SimpleProductBuilder_ShouldProduceSimpleProduct()
    {
        // arrange
        var builder = new SimpleProductBuilder();

        // act
        builder.BuildName();
        builder.BuildDescription();
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

        // act
        builder.BuildName();
        builder.BuildDescription();
        var product = builder.Build();

        // assert
        product.Should().Match<Product>(p => p.Name == "complex product");
        product.Should().Match<Product>(p => p.Description == "complex product description");
    }
}
