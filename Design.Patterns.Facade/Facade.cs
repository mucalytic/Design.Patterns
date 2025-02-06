using Xunit.Abstractions;

namespace Design.Patterns.Facade;

public class Facade(ITestOutputHelper helper)
{
    public void Operation()
    {
        var class1 = new Class1(helper);
        var class2 = new Class2(helper);
        var class3 = new Class3(helper);
        var class4 = new Class4(helper, class2);
        class4.Operation4(class3);
        class1.Operation1();
    }
}
