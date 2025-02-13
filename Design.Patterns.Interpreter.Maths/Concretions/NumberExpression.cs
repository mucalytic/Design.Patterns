using Design.Patterns.Interpreter.Maths.Abstractions;
using System.Numerics;

namespace Design.Patterns.Interpreter.Maths.Concretions;

public class NumberExpression<T>(T number) : Expression<T> where T : INumber<T>
{
    public override T Interpret() => number;
}
