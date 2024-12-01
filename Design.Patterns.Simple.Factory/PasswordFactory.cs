namespace Design.Patterns.Simple.Factory;

// a concrete class that creates a concrete instance from a set of defined classes
// using inheritance or interface implementation
public class PasswordFactory
{
    public static IPassword Generate(ushort length) =>
        length < 5 ? new SimplePassword()
                   : new ComplexPassword();
}
