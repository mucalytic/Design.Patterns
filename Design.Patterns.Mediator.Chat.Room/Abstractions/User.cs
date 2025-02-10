using Design.Patterns.Mediator.Chat.Room.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Mediator.Chat.Room.Abstractions;

public abstract class User(ITestOutputHelper helper, string name)
{
    protected IChatMediator? ChatMediator;

    public string Name => name;
    
    public void SetMediator(IChatMediator chatMediator) =>
        ChatMediator = chatMediator;

    public virtual void Send(string message) =>
        ChatMediator?.Notify(this, message);

    public virtual void Receive(string message, string senderName) =>
        helper.WriteLine($"[{Name}] {senderName} says: {message}");
}
