using Design.Patterns.Mediator.Abstractions;
using Xunit.Abstractions;

namespace Design.Patterns.Mediator.Concretions;

public class Colleague2(ITestOutputHelper helper) : Colleague
{
    public void Operation2()
    {
        const string @event = $"{nameof(Colleague2)} did {nameof(Operation2)}";
        helper.WriteLine(@event);
        Mediator?.Notify(this, @event);
    }

    public override void Receive(string @event) =>
        helper.WriteLine($"{nameof(Colleague2)} received {@event}");
}
