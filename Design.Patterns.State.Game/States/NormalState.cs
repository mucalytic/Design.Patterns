using Design.Patterns.State.Game.Interfaces;

namespace Design.Patterns.State.Game.States;

public class NormalState : ICharacterState
{
    public void HandleDamage(Character character, int damage)
    {
        throw new NotImplementedException();
    }

    public void HandlePowerUp(Character character)
    {
        throw new NotImplementedException();
    }

    public void HandleUpdate(Character character)
    {
        throw new NotImplementedException();
    }
}
