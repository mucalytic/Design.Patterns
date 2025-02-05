using Design.Patterns.Adapter.Interfaces;

namespace Design.Patterns.Adapter;

public class Adapter(Adaptee adaptee) : ITarget
{
    public void Request() =>
        adaptee.SpecificRequest();
}
