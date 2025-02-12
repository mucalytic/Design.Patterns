using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Abstractions;
using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Models;
using Xunit.Abstractions;

namespace Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Concretions;

public class KeywordHandler(ITestOutputHelper helper, SpamHandler? successor = null) : SpamHandler(successor)
{
    private readonly string[] _keywords =
    [
        "Nigerian Prince",
        "Million Dollars"
    ];
    
    public override bool HandleSpam(Email email)
    {
        if (!ContainsSpamKeywords(email.Body) && !ContainsSpamKeywords(email.Subject))
        {
            return Successor is not null && Successor.HandleSpam(email);
        }
        helper.WriteLine("Email contains spam keywords.");
        return true;
    }

    private bool ContainsSpamKeywords(string text) =>
        _keywords.Any(text.Contains);
}
