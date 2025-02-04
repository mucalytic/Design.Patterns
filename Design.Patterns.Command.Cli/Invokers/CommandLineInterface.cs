using Design.Patterns.Command.Cli.Interfaces;

namespace Design.Patterns.Command.Cli.Invokers;

public class CommandLineInterface
{
    private readonly Dictionary<string, ICommand> _commands = new();
    
    public void RegisterCommand(string name, ICommand command)
    {
        
    }

    public void ExecuteCommand(string name, string[] args)
    {
        
    }
}
