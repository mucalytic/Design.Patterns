using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Abstractions;
using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Concretions;
using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Models;
using Xunit.Abstractions;

namespace Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Client;

public class SpamDetectionSystem(ITestOutputHelper helper)
{
    private readonly SpamHandler _chain =
        new KeywordHandler(helper,
            new BlacklistHandler(helper,
                new MachineLearningHandler(helper)));

    public bool CheckForSpam(Email email) =>
        _chain.HandleSpam(email);
}
