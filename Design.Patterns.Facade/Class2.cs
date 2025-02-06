using Xunit.Abstractions;

namespace Design.Patterns.Facade;

public class Class2(ITestOutputHelper helper)
{
    public void Operation2() => helper.WriteLine(nameof(Operation2));
}
