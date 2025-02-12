namespace Design.Patterns.Interpreter.Abstractions;

public abstract class Expression
{
    public abstract void Interpret(string context);
}
