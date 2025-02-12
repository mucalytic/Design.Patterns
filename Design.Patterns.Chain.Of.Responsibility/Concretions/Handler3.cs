using Design.Patterns.Chain.Of.Responsibility.Abstractions;
using Xunit.Abstractions;

namespace Design.Patterns.Chain.Of.Responsibility.Concretions;

public class Handler3(ITestOutputHelper helper) : Handler
{
    public override void Handle(string request)
    {
        if (request == "world")
        {
            helper.WriteLine($"{nameof(Handler3)} handled request");
            return;
        }
        Successor?.Handle(request);
    }
}
