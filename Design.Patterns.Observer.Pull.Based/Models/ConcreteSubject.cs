using Design.Patterns.Observer.Pull.Based.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Observer.Pull.Based.Models;

public class ConcreteSubject(ITestOutputHelper helper) : ISubject
{
    private readonly HashSet<IObserver> _observers = [];
    
    private string _state = string.Empty;

    public void Attach(IObserver observer)
    {
        if (!_observers.Add(observer))
        {
            helper.WriteLine("Observer already attached");
        }
    }

    public void Detach(IObserver observer)
    {
        if (!_observers.Remove(observer))
        {
            helper.WriteLine("Observer was not attached");
        }
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    public void SetState(string state)
    {
        _state = state;
        Notify();
    }

    public string GetState() => _state;
}
