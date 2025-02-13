using Design.Patterns.Interpreter.Search.Query.Abstractions;

namespace Design.Patterns.Interpreter.Search.Query.Concretions;

public class NotExpression(string word) : Expression
{
    public override List<string> Interpret(List<string> words) =>
        words.Where(s => !s.Equals(word, StringComparison.OrdinalIgnoreCase)).ToList();
}
