using Design.Patterns.Command.Interfaces;

namespace Design.Patterns.Command.Invokers;

public class Invoker
{
    private readonly HashSet<ICommand> _commands = [];
    private readonly Stack<ICommand> _undoStack = new();
    
    public void AddCommand(ICommand command) =>
        _commands.Add(command);

    public void UndoLastCommand()
    {
        var command = _undoStack.Pop();
        command.Undo();
    }

    public void ExecuteCommands()
    {
        foreach (var command in _commands)
        {
            command.Execute();
            _undoStack.Push(command);
        }
        _commands.Clear();
    }
}
