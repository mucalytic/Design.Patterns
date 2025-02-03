using Design.Patterns.Classic.Builder.Without.Director.Interfaces;
using Design.Patterns.Classic.Builder.Without.Director.Models;

namespace Design.Patterns.Classic.Builder.Without.Director.Builders;

public class ComplexProductBuilder : IProductBuilder
{
    private string _name = string.Empty;
    private string _description = string.Empty;
    
    public void BuildName() =>
        _name = "complex product";

    public void BuildDescription() =>
        _description = "complex product description";

    public Product Build() =>
        new(_name, _description);
}
