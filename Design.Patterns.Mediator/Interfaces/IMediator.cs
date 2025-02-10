using Design.Patterns.Mediator.Abstractions;

namespace Design.Patterns.Mediator.Interfaces;

public interface IMediator
{
    void Notify(Colleague colleague, string @event);
}
