using Design.Patterns.State.Game.Interfaces;

namespace Design.Patterns.State.Game;

public class Character
{
    private ICharacterState? _state;
    
    public void SetState(ICharacterState? state) =>
        _state = state;

    public void Request() { }
}
