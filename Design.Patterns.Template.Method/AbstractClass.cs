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

    protected abstract void PrimitiveOperation1();
    protected abstract void PrimitiveOperation2();
    
    protected virtual void Hook() =>
        helper.WriteLine($"{nameof(AbstractClass)}:{nameof(Hook)} called");
}
