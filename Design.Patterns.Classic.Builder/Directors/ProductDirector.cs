using Design.Patterns.Classic.Builder.Interfaces;

namespace Design.Patterns.Classic.Builder.Directors;

public class ProductDirector(IProductBuilder builder)
{
    public void ConstructProduct()
    {
        builder.BuildName();
        builder.BuildDescription();
    }
}
