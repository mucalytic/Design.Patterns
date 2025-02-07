using Xunit.Abstractions;

namespace Design.Patterns.Template.Method;

public class ConcreteClass1(ITestOutputHelper helper) : AbstractClass(helper) 
{
    public override void PrimitiveOperation1() =>
        helper.WriteLine($"{nameof(ConcreteClass1)}:{nameof(PrimitiveOperation1)} called");

    public override void PrimitiveOperation2() =>
        helper.WriteLine($"{nameof(ConcreteClass1)}:{nameof(PrimitiveOperation2)} called");
}
