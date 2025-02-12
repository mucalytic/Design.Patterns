using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Abstractions;

namespace Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Concretions;

public class Handler1 : Handler
{
    public override void Handle(string request)
    {
        throw new NotImplementedException();
    }
}
