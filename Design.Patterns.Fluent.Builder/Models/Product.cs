namespace Design.Patterns.Fluent.Builder.Models;

public record Product(string Name, string Description)
{
    public class Builder
    {
        private string _name = string.Empty;
        private string _description = string.Empty;

        public Builder WithName(string name)
        {
            _name = name;
            return this;
        }

        public Builder WithDescription(string description)
        {
            _description = description;
            return this;
        }

        public Product Build() =>
            new(_name, _description);
    }
}
