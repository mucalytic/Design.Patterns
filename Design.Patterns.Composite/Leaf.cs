using Xunit.Abstractions;

namespace Design.Patterns.Composite;

public class Leaf(ITestOutputHelper helper) : Component
{
    public override void Operation()
    {
        throw new NotImplementedException();
    }

    public override void Add(Component component)
    {
        throw new NotImplementedException();
    }

    public override void Remove(Component component)
    {
        throw new NotImplementedException();
    }

    public override Component GetChild()
    {
        throw new NotImplementedException();
    }
}
