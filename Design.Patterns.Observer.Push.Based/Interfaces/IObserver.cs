namespace Design.Patterns.Observer.Push.Based.Interfaces;

public interface IObserver : IDisposable
{
    void Update(string state);
}
