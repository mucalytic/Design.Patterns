using Design.Patterns.Interpreter.Abstractions;

namespace Design.Patterns.Interpreter.Concretions;

public class TerminalExpression : Expression
{
    public override void Interpret(string context)
    {
        throw new NotImplementedException();
    }
}
