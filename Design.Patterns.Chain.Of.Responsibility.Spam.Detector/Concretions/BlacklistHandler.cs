using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Abstractions;
using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Models;
using Xunit.Abstractions;

namespace Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Concretions;

public class BlacklistHandler(ITestOutputHelper helper, SpamHandler? successor = null) : SpamHandler(successor)
{
    private readonly string[] _blacklist = 
    [
        "spam"
    ];
    
    public override bool HandleSpam(Email email)
    {
        if (!IsBlacklisted(email.Sender))
        {
            return Successor is not null && Successor.HandleSpam(email);
        }
        helper.WriteLine("Email sent by blacklisted address.");
        return true;
    }
    
    private bool IsBlacklisted(string emailAddress) =>
        _blacklist.Any(emailAddress.Contains);
}
