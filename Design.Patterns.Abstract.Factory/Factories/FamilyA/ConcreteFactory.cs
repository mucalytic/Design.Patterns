using Design.Patterns.Abstract.Factory.Interfaces;

namespace Design.Patterns.Abstract.Factory.Factories.FamilyA;

public class ConcreteFactory : AbstractFactory
{
    public override IProduct1 CreateProduct1() =>
        new Models.FamilyA.ConcreteProduct1();

    public override IProduct2 CreateProduct2() =>
        new Models.FamilyA.ConcreteProduct2();
}
