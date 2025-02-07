using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.State.Game;

public class StateTests
{
    [Fact]
    public void Character_SwitchesBetweenStates_WhenUpdatesAreMade()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var character = new Character(helper);

        // act
        character.TakeDamage(30);
        character.CollectPowerUp();
        character.TakeDamage(30);
        for (var i = 0; i < 12; i++)
        {
            character.Update();
        }
        character.TakeDamage(30);
        character.TakeDamage(70);
        
        // assert
        helper.Received(1).WriteLine("Health changed to 70");
        helper.Received(1).WriteLine("PowerUp changed to True");
        helper.Received(1).WriteLine("Changing state to Powered Up");
        helper.Received(1).WriteLine("Health changed to 55");
        helper.Received(1).WriteLine("Changing state to Normal");
        helper.Received(1).WriteLine("PowerUp changed to False");
        helper.Received(1).WriteLine("Health changed to 25");
        helper.Received(1).WriteLine("Changing state to Injured");
        helper.Received(1).WriteLine("Health changed to 0");
        helper.Received(1).WriteLine("Changing state to Defeated");
    }
}
