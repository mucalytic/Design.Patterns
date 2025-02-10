using Design.Patterns.Mediator.Chat.Room.Abstractions;
using Design.Patterns.Mediator.Chat.Room.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Mediator.Chat.Room.Concretions;

public class ChatRoom(ITestOutputHelper helper) : IChatMediator
{
    private readonly HashSet<User> _users = [];

    public void AddUser(User user)
    {
        if (_users.Add(user))
        {
            user.SetMediator(this);
            return;
        }
        helper.WriteLine("User already added");
    }

    public void Notify(User user, string message)
    {
        foreach (var recipient in _users.Except([user]))
        {
            recipient.Receive(message, user.Name);
        }
    }
}
