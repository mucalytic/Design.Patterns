using Design.Patterns.Mediator.Interfaces;

namespace Design.Patterns.Mediator.Abstractions;

public abstract class Colleague
{
    protected IMediator? Mediator;
    
    public void SetMediator(IMediator mediator) =>
        Mediator = mediator;

    public abstract void Receive(string @event);
}
