using Design.Patterns.State.Game.Interfaces;

namespace Design.Patterns.State.Game.States;

public class DefeatedState : ICharacterState
{
    public void HandleDamageTaken(Character character, int amount) { }

    public void HandlePowerUpCollected(Character character) { }

    public void HandleUpdate(Character character) { }
    
    public string Name { get; } = "Defeated";
}
