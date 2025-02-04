using Design.Patterns.Command.Receivers;
using Design.Patterns.Command.Invokers;
using Design.Patterns.Command.Commands;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Command;

public class CommandTests
{
    [Fact]
    public void Commands_AreReceivedAndInvoked_AndLastCommandIsUndone()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var receiver = new Receiver(helper);
        var command1 = new ConcreteCommand(receiver, "1");
        var command2 = new ConcreteCommand(receiver, "2");
        var command3 = new ConcreteCommand(receiver, "3");
        var invoker = new Invoker();

        // act
        invoker.AddCommand(command1);
        invoker.AddCommand(command2);
        invoker.AddCommand(command3);
        invoker.ExecuteCommands();
        invoker.UndoLastCommand();
        
        //assert
        helper.Received(1).WriteLine("Invoking 1");
        helper.Received(1).WriteLine("Invoking 2");
        helper.Received(1).WriteLine("Invoking 3");
        helper.Received(1).WriteLine("Undoing 3");
    }
}
