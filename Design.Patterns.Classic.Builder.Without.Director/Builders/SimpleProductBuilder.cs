using Design.Patterns.Classic.Builder.Without.Director.Interfaces;
using Design.Patterns.Classic.Builder.Without.Director.Models;

namespace Design.Patterns.Classic.Builder.Without.Director.Builders;

public class SimpleProductBuilder : IProductBuilder
{
    private string _name = string.Empty;
    private string _description = string.Empty;
    
    public void BuildName() =>
        _name = "simple product";

    public void BuildDescription() =>
        _description = "simple product description";

    public Product Build() =>
        new(_name, _description);
}
