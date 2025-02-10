using Design.Patterns.Mediator.Chat.Room.Abstractions;
using Xunit.Abstractions;

namespace Design.Patterns.Mediator.Chat.Room.Concretions;

public class AdminUser(ITestOutputHelper helper, string name) : User(helper, name)
{
    public override void Send(string message) =>
        ChatMediator?.Notify(this, $"ADMIN MESSAGE! ## {message} ##");
}
