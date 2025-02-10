using Design.Patterns.Mediator.Chat.Room.Abstractions;

namespace Design.Patterns.Mediator.Chat.Room.Interfaces;

public interface IChatMediator
{
    void AddUser(User user);
    void Notify(User user, string message);
}
