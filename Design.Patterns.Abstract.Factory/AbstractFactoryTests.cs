using Design.Patterns.Abstract.Factory.Factories;
using FluentAssertions;

namespace Design.Patterns.Abstract.Factory;

public class AbstractFactoryTests
{
    [Fact]
    public void ConcreteFactoryForFamilyA_CreatesProductsFromFamilyA()
    {
        // arrange
        AbstractFactory factory = new Factories.FamilyA.ConcreteFactory();
        
        // act
        var product1 = factory.CreateProduct1();
        var product2 = factory.CreateProduct2();

        // assert
        product1.Should().BeOfType<Models.FamilyA.ConcreteProduct1>();
        product2.Should().BeOfType<Models.FamilyA.ConcreteProduct2>();
    }

    [Fact]
    public void ConcreteFactoryForFamilyB_CreatesProductsFromFamilyB()
    {
        // arrange
        AbstractFactory factory = new Factories.FamilyB.ConcreteFactory();
        
        // act
        var product1 = factory.CreateProduct1();
        var product2 = factory.CreateProduct2();

        // assert
        product1.Should().BeOfType<Models.FamilyB.ConcreteProduct1>();
        product2.Should().BeOfType<Models.FamilyB.ConcreteProduct2>();
    }
}
