using Design.Patterns.Command.Cli.Interfaces;
using Design.Patterns.Command.Cli.Receivers;

namespace Design.Patterns.Command.Cli.Commands;

public class MakeDirectoryCommand : ICommand
{
    private readonly FileSystemReceiver _receiver;
    
    public void Execute(string[] args) =>
        _receiver.MakeDirectory(args.First());
}
