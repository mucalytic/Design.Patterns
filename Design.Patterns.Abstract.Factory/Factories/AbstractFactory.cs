using Design.Patterns.Abstract.Factory.Interfaces;

namespace Design.Patterns.Abstract.Factory.Factories;

public abstract class AbstractFactory
{
    public abstract IProduct1 CreateProduct1();
    public abstract IProduct2 CreateProduct2();
}
