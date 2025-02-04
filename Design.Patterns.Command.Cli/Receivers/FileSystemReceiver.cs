using Xunit.Abstractions;

namespace Design.Patterns.Command.Cli.Receivers;

public class FileSystemReceiver(ITestOutputHelper helper)
{
    public void MakeDirectory(string name) =>
        helper.WriteLine($"Made directory: {name}");
    
    public void ChangeDirectory(string path) =>
        helper.WriteLine($"Changed directory to: {path}");
    
    public void ListFiles() =>
        helper.WriteLine("Listing files in current directory");
}
