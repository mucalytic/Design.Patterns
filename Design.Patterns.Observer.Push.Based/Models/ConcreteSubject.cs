using Design.Patterns.Observer.Push.Based.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Observer.Push.Based.Models;

public class ConcreteSubject(ITestOutputHelper helper) : ISubject
{
    private readonly HashSet<IObserver> _observers = [];
    
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

    public void Notify(string state)
    {
        foreach (var observer in _observers)
        {
            observer.Update(state);
        }
    }
}
