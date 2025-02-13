using Design.Patterns.Interpreter.Search.Query.Abstractions;

namespace Design.Patterns.Interpreter.Search.Query.Concretions;

public class AndExpression(Expression left, Expression right) : Expression
{
    public override List<string> Interpret(List<string> words) =>
        left.Interpret(words).Intersect(right.Interpret(words)).ToList();
}
