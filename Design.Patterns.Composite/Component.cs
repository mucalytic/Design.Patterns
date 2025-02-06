namespace Design.Patterns.Composite;

public abstract class Component
{
    public abstract void Operation();
    public abstract void Add(Component component);
    public abstract void Remove(Component component);
    public abstract Component GetChild();
}
