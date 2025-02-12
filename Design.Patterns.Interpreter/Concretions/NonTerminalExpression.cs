using Design.Patterns.Interpreter.Abstractions;

namespace Design.Patterns.Interpreter.Concretions;

public class NonTerminalExpression : Expression
{
    protected List<Expression> Expressions = [];
    
    public override void Interpret(string context)
    {
        throw new NotImplementedException();
    }
}
