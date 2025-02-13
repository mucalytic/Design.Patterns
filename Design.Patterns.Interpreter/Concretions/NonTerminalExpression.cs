using Design.Patterns.Interpreter.Abstractions;
using System.Reactive;

namespace Design.Patterns.Interpreter.Concretions;

public class NonTerminalExpression : Expression
{
    protected List<Expression> Expressions = [];
    
    public override Unit Interpret(Unit context)
    {
        throw new NotImplementedException();
    }
}
