using Xunit.Abstractions;

namespace Design.Patterns.Facade;

public class Class4(ITestOutputHelper helper, Class2 class2)
{
    public void Operation4(Class3 class3)
    {
        helper.WriteLine(nameof(Operation4));
        class2.Operation2();
        class3.Operation3();
    }
}
