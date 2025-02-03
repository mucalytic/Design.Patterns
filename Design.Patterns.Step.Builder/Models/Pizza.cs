using Design.Patterns.Step.Builder.Interfaces;

namespace Design.Patterns.Step.Builder.Models;

public record Pizza(Dough Dough, string Sauce, string Cheese, List<string> Toppings)
{
    public class Builder : IDoughStep, ISauceStep, ICheeseStep, IToppingStep
    {
        private string _sauce = string.Empty;
        private string _cheese = string.Empty;
        private Dough _dough = new(0, string.Empty);
        private readonly List<string> _toppings = [];

        private Builder() { }

        public static IDoughStep New() => new Builder();
        
        public ISauceStep WithDough(Action<Dough.Builder> buildDoughAction)
        {
            var doughBuilder = new Dough.Builder();
            buildDoughAction(doughBuilder);
            _dough = doughBuilder.Build();
            return this;
        }

        public ICheeseStep WithSauce(string sauce)
        {
            _sauce = sauce;
            return this;
        }

        public IToppingStep WithCheese(string cheese)
        {
            _cheese = cheese;
            return this;
        }

        public IToppingStep WithTopping(string topping)
        {
            _toppings.Add(topping);
            return this;
        }

        public Pizza Build() =>
            new(_dough, _sauce, _cheese, _toppings);
    }
}
