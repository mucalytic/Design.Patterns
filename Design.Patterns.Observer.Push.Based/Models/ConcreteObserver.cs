using Design.Patterns.Observer.Push.Based.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Observer.Push.Based.Models;

public class ConcreteObserver(ITestOutputHelper helper, ISubject subject) : IObserver
{
    public void Update(string state) =>
        helper.WriteLine($"Observer reacted to state {state}");

    public void Dispose() =>
        subject.Detach(this);
}
