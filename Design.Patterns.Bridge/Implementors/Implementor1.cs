using Design.Patterns.Bridge.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Bridge.Implementors;

public class Implementor1(ITestOutputHelper helper) : IImplementor
{
    public void Print() =>
        helper.WriteLine($"Hello from {nameof(Implementor1)}");
}
