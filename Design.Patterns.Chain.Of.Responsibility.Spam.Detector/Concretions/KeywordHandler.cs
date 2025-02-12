using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Abstractions;
using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Models;

namespace Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Concretions;

public class KeywordHandler : SpamHandler
{
    public override void HandleSpam(Email email)
    {
        throw new NotImplementedException();
    }
}
