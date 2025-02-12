namespace Design.Patterns.Interpreter.Maths.Abstractions;

public abstract class Expression<T>
{
    public abstract T Interpret(string context);
}
