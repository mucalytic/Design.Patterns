using Xunit.Abstractions;

namespace Design.Patterns.Template.Method;

public abstract class AbstractClass(ITestOutputHelper helper)
{
    public void TemplateMethod()
    {
        PrimitiveOperation1();
        PrimitiveOperation2();
        Hook();
    }

    public abstract void PrimitiveOperation1();
    public abstract void PrimitiveOperation2();
    
    public virtual void Hook() =>
        helper.WriteLine($"{nameof(AbstractClass)}:{nameof(Hook)} called");
}
