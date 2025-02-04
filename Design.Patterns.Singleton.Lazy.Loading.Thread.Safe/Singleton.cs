namespace Design.Patterns.Singleton.Lazy.Loading.Thread.Safe;

public sealed class Singleton
{
    private static readonly Lazy<Singleton> LazyInstance = new(() => new Singleton());
    
    private Singleton() { }

    public static Singleton Instance => LazyInstance.Value;
}
