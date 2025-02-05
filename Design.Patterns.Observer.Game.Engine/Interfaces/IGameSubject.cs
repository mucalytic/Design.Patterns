namespace Design.Patterns.Observer.Game.Engine.Interfaces;

public interface IGameSubject
{
    void Attach(IGameObserver observer);
    void Detach(IGameObserver observer);
    void NotifyHealth();
    void NotifyScore();
}
