using Xunit.Abstractions;

namespace Design.Patterns.Command.Receivers;

public class Receiver(ITestOutputHelper helper)
{
    public void Action(string message) => helper.WriteLine($"Invoking {message}");
    
    public void UndoAction(string message) => helper.WriteLine($"Undoing {message}");
}
