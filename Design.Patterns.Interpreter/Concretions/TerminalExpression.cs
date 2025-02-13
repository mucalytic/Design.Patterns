using Design.Patterns.Interpreter.Abstractions;
using System.Reactive;

namespace Design.Patterns.Interpreter.Concretions;

public class TerminalExpression : Expression
{
    public override Unit Interpret(Unit context)
    {
        throw new NotImplementedException();
    }
}
