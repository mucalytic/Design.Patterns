using Design.Patterns.State.Game.Interfaces;

namespace Design.Patterns.State.Game.States;

public class InjuredState : ICharacterState
{
    public void HandleDamageTaken(Character character, int amount)
    {
        character.ModifyHealth(-(amount * 2));
        if (character.Health <= 0)
        {
            character.SetState(new DefeatedState());
        }
    }

    public void HandlePowerUpCollected(Character character)
    {
        character.ModifyHealth(50);
        character.SetState(new NormalState());
    }

    public void HandleUpdate(Character character)
    {
        character.ModifyHealth(2);
        if (character.Health >= 30)
        {
            character.SetState(new NormalState());
        }
    }

    public string Name { get; } = "Injured";
}
