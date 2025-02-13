using Design.Patterns.Interpreter.Maths.Abstractions;
using System.Numerics;

namespace Design.Patterns.Interpreter.Maths.Concretions;

public class MultiplyExpression<T>(Expression<T> left, Expression<T> right) : Expression<T> where T : INumber<T>
{
    public override T Interpret() =>
        left.Interpret() * right.Interpret();
}
