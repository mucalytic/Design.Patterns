using Design.Patterns.Interpreter.Search.Query.Abstractions;

namespace Design.Patterns.Interpreter.Search.Query.Concretions;

public class ContainsExpression(string value) : Expression
{
    public override List<string> Interpret(List<string> words) =>
        words.Where(s => s.Contains(value, StringComparison.OrdinalIgnoreCase)).ToList();
}
