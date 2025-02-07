using Design.Patterns.State.Game.Interfaces;
using Design.Patterns.State.Game.States;
using Xunit.Abstractions;

namespace Design.Patterns.State.Game;

public class Character(ITestOutputHelper helper)
{
    private ICharacterState _state = new NormalState();
    
    public bool HasPowerUp { get; private set; }
    public int  Health     { get; private set; } = 100;

    public void SetState(ICharacterState state)
    {
        helper.WriteLine($"Changing state to {state.Name}");
        _state = state;
    }

    public void TakeDamage(int damage) =>
        _state.HandleDamageTaken(this, damage);

    public void CollectPowerUp() =>
        _state.HandlePowerUpCollected(this);

    public void Update() =>
        _state.HandleUpdate(this);

    public void ModifyHealth(int amount)
    {
        Health = Math.Clamp(Health + amount, 0, 100);
        helper.WriteLine($"Health changed to {Health}");
    }

    public void SetPowerUp(bool hasPowerUp)
    {
        HasPowerUp = hasPowerUp;
        helper.WriteLine($"PowerUp changed to {HasPowerUp}");
    }
}
