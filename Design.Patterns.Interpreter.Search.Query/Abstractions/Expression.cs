namespace Design.Patterns.Interpreter.Search.Query.Abstractions;

public abstract class Expression
{
    public abstract List<string> Interpret(List<string> words);
}
