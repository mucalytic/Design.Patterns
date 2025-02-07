using Design.Patterns.State.Game.Interfaces;

namespace Design.Patterns.State.Game.States;

public class NormalState : ICharacterState
{
    public void HandleDamageTaken(Character character, int amount)
    {
        character.ModifyHealth(-amount);
        if (character.Health < 30)
        {
            character.SetState(new InjuredState());
        }
    }

    public void HandlePowerUpCollected(Character character)
    {
        character.SetPowerUp(true);
        character.SetState(new PoweredUpState());
    }

    public void HandleUpdate(Character character) { }

    public string Name { get; } = "Normal";
}
