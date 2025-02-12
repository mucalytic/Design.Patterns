using Design.Patterns.Chain.Of.Responsibility.Abstractions;
using Xunit.Abstractions;

namespace Design.Patterns.Chain.Of.Responsibility.Concretions;

public class Handler2(ITestOutputHelper helper) : Handler
{
    public override void Handle(string request)
    {
        if (request == "there")
        {
            helper.WriteLine($"{nameof(Handler2)} handled request");
            return;
        }
        Successor?.Handle(request);
    }
}
