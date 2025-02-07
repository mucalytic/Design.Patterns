using Xunit.Abstractions;

namespace Design.Patterns.Template.Method;

public class ConcreteClass2(ITestOutputHelper helper) : AbstractClass(helper) 
{
    public override void PrimitiveOperation1() =>
        helper.WriteLine($"{nameof(ConcreteClass2)}:{nameof(PrimitiveOperation1)} called");

    public override void PrimitiveOperation2() =>
        helper.WriteLine($"{nameof(ConcreteClass2)}:{nameof(PrimitiveOperation2)} called");

    public override void Hook() =>
        helper.WriteLine($"{nameof(ConcreteClass2)}:{nameof(Hook)} called");
}
