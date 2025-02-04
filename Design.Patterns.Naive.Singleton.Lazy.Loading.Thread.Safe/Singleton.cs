namespace Design.Patterns.Naive.Singleton.Lazy.Loading.Thread.Safe;

public sealed class Singleton
{
    private static Singleton? _instance;

    private static readonly object Lock = new();
    
    private Singleton() { }

    public static Singleton Instance
    {
        get // this implementation is called double-checked locking
        {
            if (_instance is not null) return _instance;
            lock (Lock) // locking is expensive so only do it once
            {
                return _instance ??= new Singleton();
            }
        }
    }
}
