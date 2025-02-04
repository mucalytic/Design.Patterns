using Design.Patterns.Command.Cli.Receivers;
using Design.Patterns.Command.Cli.Invokers;
using Design.Patterns.Command.Cli.Commands;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Command.Cli;

public class CommandTests
{
    [Fact]
    public void CliCommands_AreExecuted()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var receiver = new FileSystemReceiver(helper);
        var cli = new CommandLineInterface(helper);

        // act
        cli.RegisterCommand("mkdir", new MakeDirectoryCommand(receiver, helper));
        cli.RegisterCommand("cd", new ChangeDirectoryCommand(receiver, helper));
        cli.RegisterCommand("ls", new ListFilesCommand(receiver, helper));
        
        cli.ExecuteCommand("ls");
        cli.ExecuteCommand("mkdir", "test");
        cli.ExecuteCommand("cd", "test");
        cli.ExecuteCommand("ls");
        
        // assert
        helper.Received(1).WriteLine("Made directory: test");
        helper.Received(1).WriteLine("Changed directory to: test");
        helper.Received(2).WriteLine("Listing files in current directory");
    }

    [Fact]
    public void MakeDirectoryCommand_WritesErrorMessage_WhenNoDirectorySpecified()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var receiver = new FileSystemReceiver(helper);
        var cli = new CommandLineInterface(helper);

        // act
        cli.RegisterCommand("mkdir", new MakeDirectoryCommand(receiver, helper));
        
        cli.ExecuteCommand("mkdir");
        
        // assert
        helper.Received(1).WriteLine("Make Directory command expecting 1 argument");
    }
    
    [Fact]
    public void ChangeDirectoryCommand_WritesErrorMessage_WhenNoDirectorySpecified()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var receiver = new FileSystemReceiver(helper);
        var cli = new CommandLineInterface(helper);

        // act
        cli.RegisterCommand("cd", new ChangeDirectoryCommand(receiver, helper));
        cli.ExecuteCommand("cd");
        
        // assert
        helper.Received(1).WriteLine("Change Directory command expecting 1 argument");
    }

    [Fact]
    public void ExecuteCommand_WritesErrorMessage_WhenCommandNotRegistered()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var cli = new CommandLineInterface(helper);

        // act
        cli.ExecuteCommand("cd");
        
        // assert
        helper.Received(1).WriteLine($"Command cd not registered");
    }

    [Fact]
    public void ExecuteCommand_WritesErrorMessage_WhenCommandRegisteredTwice()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var receiver = new FileSystemReceiver(helper);
        var cli = new CommandLineInterface(helper);

        // act
        cli.RegisterCommand("cd", new ChangeDirectoryCommand(receiver, helper));
        cli.RegisterCommand("cd", new ChangeDirectoryCommand(receiver, helper));
        
        // assert
        helper.Received(1).WriteLine($"Command cd already registered");
    }
}
