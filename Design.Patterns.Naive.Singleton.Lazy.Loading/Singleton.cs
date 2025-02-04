namespace Design.Patterns.Naive.Singleton.Lazy.Loading;

public sealed class Singleton
{
    private static Singleton? _instance;
    
    private Singleton() { }

    public static Singleton Instance =>
        _instance ??= new Singleton();
}
