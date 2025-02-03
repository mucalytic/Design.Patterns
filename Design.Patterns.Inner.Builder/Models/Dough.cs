namespace Design.Patterns.Inner.Builder.Models;

public record Dough(int Thickness, string Flour)
{
    public class Builder
    {
        private int _thickness;
        private string _flour = string.Empty;

        public Builder WithThickness(int thickness)
        {
            _thickness = thickness;
            return this;
        }

        public Builder WithFlour(string flour)
        {
            _flour = flour;
            return this;
        }

        public Dough Build() =>
            new(_thickness, _flour);
    }
}
