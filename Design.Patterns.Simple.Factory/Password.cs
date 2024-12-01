namespace Design.Patterns.Simple.Factory;

// a static factory method - a static method defined in a concrete type that creates that type
public class Password
{
    // private constructor limits creation to the static method
    private Password() { }

    public static Password Generate()
    {
        // complex logic
        return new Password();
    }
}
