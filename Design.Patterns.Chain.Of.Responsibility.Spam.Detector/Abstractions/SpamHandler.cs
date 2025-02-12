using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Models;

namespace Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Abstractions;

public abstract class SpamHandler
{
    protected SpamHandler? Successor { get; private set; }

    public void SetSuccessor(SpamHandler successor) =>
        Successor = successor;
    
    public abstract void HandleSpam(Email email);
}
