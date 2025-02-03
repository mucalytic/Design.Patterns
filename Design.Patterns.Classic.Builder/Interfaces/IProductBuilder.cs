using Design.Patterns.Classic.Builder.Models;

namespace Design.Patterns.Classic.Builder.Interfaces;

public interface IProductBuilder
{
    Product Build();
    void    BuildName();
    void    BuildDescription();
}
