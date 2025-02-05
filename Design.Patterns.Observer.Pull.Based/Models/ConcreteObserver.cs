using Design.Patterns.Observer.Pull.Based.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Observer.Pull.Based.Models;

public class ConcreteObserver(ITestOutputHelper helper, ConcreteSubject subject) : IObserver
{
    public void Update()
    {
        var state = subject.GetState();
        helper.WriteLine($"Observer reacted to state {state}");
    }
}
