namespace Design.Patterns.State.Game.Interfaces;

public interface ICharacterState
{
    void HandleDamageTaken(Character character, int amount);
    void HandlePowerUpCollected(Character character);
    void HandleUpdate(Character character);
    string Name { get; }
}
