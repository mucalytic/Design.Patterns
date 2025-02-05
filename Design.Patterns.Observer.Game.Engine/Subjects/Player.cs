using Design.Patterns.Observer.Game.Engine.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Observer.Game.Engine.Subjects;

public class Player(ITestOutputHelper helper) : IGameSubject
{
    private readonly HashSet<IGameObserver> _observers = [];

    private int _health;
    private int _score;
    
    public void Attach(IGameObserver observer)
    {
        if (!_observers.Add(observer))
        {
            helper.WriteLine("Observer already attached");
        }
    }
    
    public void Detach(IGameObserver observer)
    {
        if (!_observers.Remove(observer))
        {
            helper.WriteLine("Observer was not attached");
        }
    }

    public void NotifyHealth()
    {
        foreach (var observer in _observers)
        {
            observer.UpdateHealth();
        }
    }

    public void NotifyScore()
    {
        foreach (var observer in _observers)
        {
            observer.UpdateScore();
        }
    }

    public int GetHealth() => _health;
    
    public int GetScore() => _score;

    public void SetHealth(int health)
    {
        _health = health;
        NotifyHealth();
    }

    public void SetScore(int score)
    {
        _score = score;
        NotifyScore();
    }
}
