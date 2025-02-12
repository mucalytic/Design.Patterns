using System.Numerics;
using Design.Patterns.Interpreter.Maths.Abstractions;

namespace Design.Patterns.Interpreter.Maths.Concretions;

public class AddExpression<T, T1, T2>(Expression<T1> left, Expression<T2> right) :
    Expression<T> where T1 : INumber<T1> where T2 : INumber<T2>
{
    public override T Interpret(string context)
    {
        throw new NotImplementedException();
    }
}
