namespace Design.Patterns.Inner.Builder.Models;

public record Pizza(Dough Dough, string Sauce, string Cheese, List<string> Toppings)
{
    public class Builder
    {
        private string _sauce = string.Empty;
        private string _cheese = string.Empty;
        private Dough _dough = new(0, string.Empty);
        private readonly List<string> _toppings = [];

        public Builder WithDough(Action<Dough.Builder> buildDoughAction)
        {
            var doughBuilder = new Dough.Builder();
            buildDoughAction(doughBuilder);
            _dough = doughBuilder.Build();
            return this;
        }

        public Builder WithSauce(string sauce)
        {
            _sauce = sauce;
            return this;
        }

        public Builder WithCheese(string cheese)
        {
            _cheese = cheese;
            return this;
        }

        public Builder WithTopping(string topping)
        {
            _toppings.Add(topping);
            return this;
        }

        public Pizza Build() =>
            new(_dough, _sauce, _cheese, _toppings);
    }
}
