using Design.Patterns.Factory.Method.Products;

namespace Design.Patterns.Factory.Method.Creators;

public class ConcreteCreator : Creator
{
    public override Product CreateProduct()
    {
        return new ConcreteProduct();
    }
}
