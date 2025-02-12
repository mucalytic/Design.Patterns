using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Models;

namespace Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Abstractions;

public abstract class SpamHandler(SpamHandler? successor)
{
    protected SpamHandler? Successor { get; } = successor;

    public abstract bool HandleSpam(Email email);
}
