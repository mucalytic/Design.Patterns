using Xunit.Abstractions;

namespace Design.Patterns.Composite;

public class Composite(ITestOutputHelper helper) : Component
{
    private readonly HashSet<Component> _components = [];

    public override void Operation()
    {
        foreach (var component in _components)
        {
            component.Operation();
        }
    }

    public override void Add(Component component)
    {
        if (!_components.Add(component))
        {
            helper.WriteLine("Component already added");
        }
    }

    public override void Remove(Component component)
    {
        if (!_components.Remove(component))
        {
            helper.WriteLine("Component was not added");
        }
    }

    public override Component? GetChild(int index)
    {
        try
        {
            return _components.ElementAt(index);
        }
        catch (ArgumentOutOfRangeException)
        {
            helper.WriteLine("Component not found");
        }
        return null;
    }
}
