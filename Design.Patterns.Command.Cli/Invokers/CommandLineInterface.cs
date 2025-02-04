using Design.Patterns.Command.Cli.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Command.Cli.Invokers;

public class CommandLineInterface(ITestOutputHelper helper)
{
    private readonly Dictionary<string, ICommand> _commands = new();

    public void RegisterCommand(string name, ICommand command)
    {
        if (!_commands.TryAdd(name, command))
        {
            helper.WriteLine($"Command {name} already registered");
        }
    }

    public void ExecuteCommand(string name, params string[] args)
    {
        if (!_commands.TryGetValue(name, out var command))
        {
            helper.WriteLine($"Command {name} not registered");
            return;
        }
        command.Execute(args);
    }
}
