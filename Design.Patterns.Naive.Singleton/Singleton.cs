namespace Design.Patterns.Naive.Singleton;

public sealed class Singleton
{
    private Singleton() { }

    public static Singleton Instance { get; } = new(); // eager loading
}
