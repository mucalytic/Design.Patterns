using Design.Patterns.Mediator.Chat.Room.Abstractions;
using Xunit.Abstractions;

namespace Design.Patterns.Mediator.Chat.Room.Concretions;

public class RegularUser(ITestOutputHelper helper, string name) : User(helper, name);
