using Design.Patterns.Proxy.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Proxy;

public class RealSubject(ITestOutputHelper helper, bool allowed) : ISubject
{
    public void Operation()
    {
        if (!allowed) return;
        helper.WriteLine($"{nameof(RealSubject)}.{nameof(Operation)}");
    }
}
