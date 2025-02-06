namespace Design.Patterns.State.Interfaces;

public interface IState
{
    public void Handle(Context context);
}
