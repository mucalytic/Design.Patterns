using Design.Patterns.Classic.Builder.Interfaces;
using Design.Patterns.Classic.Builder.Models;

namespace Design.Patterns.Classic.Builder.Builders;

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
