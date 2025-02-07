using Design.Patterns.State.Game.Interfaces;

namespace Design.Patterns.State.Game.States;

public class PoweredUpState : ICharacterState
{
    private int _powerUpDuration = 10;
    
    public void HandleDamageTaken(Character character, int amount) =>
        character.ModifyHealth(-(amount / 2));

    public void HandlePowerUpCollected(Character character) =>
        _powerUpDuration = 10;

    public void HandleUpdate(Character character)
    {
        _powerUpDuration--;
        if (_powerUpDuration > 0) return;
        character.SetState(new NormalState());
        character.SetPowerUp(false);
    }

    public string Name { get; } = "Powered Up";
}
