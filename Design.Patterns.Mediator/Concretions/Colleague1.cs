using Design.Patterns.Mediator.Abstractions;
using Xunit.Abstractions;

namespace Design.Patterns.Mediator.Concretions;

public class Colleague1(ITestOutputHelper helper) : Colleague
{
    public void Operation1()
    {
        const string @event = $"{nameof(Colleague1)} did {nameof(Operation1)}"; 
        helper.WriteLine(@event);
        Mediator?.Notify(this, @event);
    }

    public override void Receive(string @event) =>
        helper.WriteLine($"{nameof(Colleague1)} received {@event}");
}
