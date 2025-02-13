using System.Numerics;

namespace Design.Patterns.Interpreter.Maths.Abstractions;

public abstract class Expression<T> where T : INumber<T>
{
    public abstract T Interpret();
}
