using Design.Patterns.Mediator.Abstractions;
using Design.Patterns.Mediator.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Mediator.Concretions;

public class Mediator : IMediator
{
    private readonly Colleague1 _colleague1;
    private readonly Colleague2 _colleague2;
    private readonly ITestOutputHelper _helper;

    public Mediator(ITestOutputHelper helper, Colleague1 colleague1, Colleague2 colleague2)
    {
        _helper = helper;
        _colleague1 = colleague1;
        _colleague1.SetMediator(this);
        _colleague2 = colleague2;
        _colleague2.SetMediator(this);
    }
    
    public void Notify(Colleague colleague, string @event)
    {
        _helper.WriteLine($"{nameof(Mediator)} notified by {colleague.GetType().Name}: {@event}");
        if (colleague == _colleague1) _colleague2.Receive(@event);
        if (colleague == _colleague2) _colleague1.Receive(@event);
    }
}
