namespace Design.Patterns.Command.Cli.Interfaces;

public interface ICommand
{
    void Execute(string[] args);
}
