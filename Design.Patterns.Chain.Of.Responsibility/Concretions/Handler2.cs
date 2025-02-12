using Design.Patterns.Chain.Of.Responsibility.Abstractions;

namespace Design.Patterns.Chain.Of.Responsibility.Concretions;

public class Handler2 : Handler
{
    public override void Handle(string request)
    {
        throw new NotImplementedException();
    }
}
