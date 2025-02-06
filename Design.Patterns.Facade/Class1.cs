using Xunit.Abstractions;

namespace Design.Patterns.Facade;

public class Class1(ITestOutputHelper helper)
{
    public void Operation1() => helper.WriteLine(nameof(Operation1));
}
