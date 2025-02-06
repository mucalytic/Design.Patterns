using Xunit.Abstractions;

namespace Design.Patterns.Facade;

public class Class3(ITestOutputHelper helper)
{
    public void Operation3() => helper.WriteLine(nameof(Operation3));
}
