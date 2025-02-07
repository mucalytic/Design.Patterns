using Design.Patterns.Proxy.Interfaces;

namespace Design.Patterns.Proxy;

public class Proxy(RealSubject realSubject) : ISubject
{
    public void Operation() =>
        realSubject.Operation();
}
