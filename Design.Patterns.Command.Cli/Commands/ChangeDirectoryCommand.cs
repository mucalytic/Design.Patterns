using Design.Patterns.Command.Cli.Interfaces;
using Design.Patterns.Command.Cli.Receivers;
using Xunit.Abstractions;

namespace Design.Patterns.Command.Cli.Commands;

public class ChangeDirectoryCommand(FileSystemReceiver receiver, ITestOutputHelper helper) : ICommand
{
    public void Execute(string[] args)
    {
        if (args.Length != 1)
        {
            helper.WriteLine("Change Directory command expecting 1 argument");
            return;
        }
        receiver.ChangeDirectory(args[0]);
    }
}
