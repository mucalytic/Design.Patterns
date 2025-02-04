using Design.Patterns.Command.Cli.Interfaces;
using Design.Patterns.Command.Cli.Receivers;
using Xunit.Abstractions;

namespace Design.Patterns.Command.Cli.Commands;

public class ListFilesCommand(FileSystemReceiver receiver, ITestOutputHelper _) : ICommand
{
    public void Execute(string[] args) =>
        receiver.ListFiles();
}
