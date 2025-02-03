using Design.Patterns.Step.Builder.Models;
using FluentAssertions;

namespace Design.Patterns.Step.Builder;

public class StepBuilderTests
{
    [Fact]
    public void PizzaBuilder_ShouldBuildPizza()
    {
        // arrange
        var pizza = Pizza.Builder.New()
            .WithDough(dough =>
                dough.WithThickness(1)
                     .WithFlour("White"))
            .WithSauce("Tomato sauce")
            .WithCheese("Mozzarella cheese")
            .WithTopping("Sausage")
            .WithTopping("Bacon")
            .WithTopping("Mushrooms")
            .WithTopping("Black Olives")
            .Build();

        // assert
        pizza.Sauce.Should().Be("Tomato sauce");
        pizza.Cheese.Should().Be("Mozzarella cheese");
        pizza.Dough.Should().BeEquivalentTo(new Dough(1, "White"));
        pizza.Toppings.Should().BeEquivalentTo(["Sausage", "Bacon", "Mushrooms", "Black Olives"]);
    }
}
