using Xunit.Abstractions;

namespace Design.Patterns.Composite;

public class Leaf(ITestOutputHelper helper) : Component
{
    public override void Operation()
    {
        helper.WriteLine($"{nameof(Leaf)}.{nameof(Operation)}");
    }
}
