namespace Design.Patterns.Cool.Singleton;

public sealed class Singleton
{
    private Singleton() { }

    static Singleton()
    {
        Name = "cool-singleton";
    }

    private class Nested
    {
        static Nested() { }
        
        internal static Singleton InnerInstance { get; } = new();
    }

    public static Singleton Instance => Nested.InnerInstance;

    public static string Name;
}
