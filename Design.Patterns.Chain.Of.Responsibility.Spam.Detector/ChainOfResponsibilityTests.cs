using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Client;
using Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Models;
using Xunit.Abstractions;
using FluentAssertions;

namespace Design.Patterns.Chain.Of.Responsibility.Spam.Detector;

public class ChainOfResponsibilityTests(ITestOutputHelper helper)
{
    [Theory]
    [InlineData("hr@where-you-work.com", "Raise.", "We're going to give you a raise!", false)]
    [InlineData("nigerian.prince@gmail.com", "I need your HELP!", "Nigerian Prince", true)] // Keyword
    [InlineData("your.friend@hotmail.com", "Come to the party!", "I'm having a party!", true)] // ML
    [InlineData("spam@hotmail.com", "Best meats!", "We have corned beef, spam, all the best canned meats!", true)] // Blacklist
    public void Handlers_ShouldBeCalledUntilSpamDetected_OrNotDetected(string sender, string subject, string body, bool expected)
    {
        // arrange
        var client = new SpamDetectionSystem(helper);
        var email = new Email(sender, subject, body);

        // act
        var result = client.CheckForSpam(email);
        
        // assert
        result.Should().Be(expected);
    }
}
