using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Abstractions;
using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Models;
using Xunit.Abstractions;

namespace Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Concretions;

public class MachineLearningHandler(ITestOutputHelper helper, SpamHandler? successor = null) : SpamHandler(successor)
{
    public override bool HandleSpam(Email email)
    {
        if (email.Body.Length % 2 == 0)
        {
            return Successor is not null && Successor.HandleSpam(email);
        }
        helper.WriteLine("Machine learning model predicted that email is spam.");
        return true;
    }
}
