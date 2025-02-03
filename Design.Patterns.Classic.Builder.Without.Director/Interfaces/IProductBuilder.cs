using Design.Patterns.Classic.Builder.Without.Director.Models;

namespace Design.Patterns.Classic.Builder.Without.Director.Interfaces;

public interface IProductBuilder
{
    Product Build();
    void    BuildName();
    void    BuildDescription();
}
