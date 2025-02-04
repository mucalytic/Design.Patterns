using Design.Patterns.Command.Interfaces;
using Design.Patterns.Command.Receivers;

namespace Design.Patterns.Command.Commands;

public class ConcreteCommand(Receiver receiver, string message) : ICommand
{
    public void Execute() => receiver.Action(message);

    public void Undo() => receiver.UndoAction(message);
}
