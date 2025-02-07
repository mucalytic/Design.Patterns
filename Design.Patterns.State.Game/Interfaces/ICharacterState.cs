namespace Design.Patterns.State.Game.Interfaces;

public interface ICharacterState
{
    void HandleDamage(Character character, int damage);
    void HandlePowerUp(Character character);
    void HandleUpdate(Character character);
}
