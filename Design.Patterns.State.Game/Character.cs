using Design.Patterns.State.Game.Interfaces;

namespace Design.Patterns.State.Game;

public class Character
{
    private ICharacterState? _state;
    private bool _hasPowerUp;
    private int _health;
    
    public void SetState(ICharacterState? state) =>
        _state = state;

    public void TakeDamage(int damage) =>
        _health += damage;
    
    public void CollectPowerUp() =>
        _hasPowerUp = true;
    
    public void Update() { }
}
