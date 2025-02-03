using Design.Patterns.Classic.Builder.Interfaces;
using Design.Patterns.Classic.Builder.Models;

namespace Design.Patterns.Classic.Builder.Builders;

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
