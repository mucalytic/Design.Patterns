using Design.Patterns.Abstract.Factory.Interfaces;

namespace Design.Patterns.Abstract.Factory.Factories.FamilyB;

public class ConcreteFactory : AbstractFactory
{
    public override IProduct1 CreateProduct1() =>
        new Models.FamilyB.ConcreteProduct1();

    public override IProduct2 CreateProduct2() =>
        new Models.FamilyB.ConcreteProduct2();
}
