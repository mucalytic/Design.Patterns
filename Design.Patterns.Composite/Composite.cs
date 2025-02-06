using Xunit.Abstractions;

namespace Design.Patterns.Composite;

public class Composite(ITestOutputHelper helper) : Component
{
    private readonly HashSet<Component> _components = [];
    
    public override void Operation()
    {
        throw new NotImplementedException();
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
    
    public override Component GetChild()
    {
        throw new NotImplementedException();
    }
}
