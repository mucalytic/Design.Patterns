using Design.Patterns.State.Interfaces;

namespace Design.Patterns.State;

public class Context
{
    private IState? _state;
    
    public void SetState(IState state) => _state = state;

    public void Request() => _state?.Handle(this);
}
