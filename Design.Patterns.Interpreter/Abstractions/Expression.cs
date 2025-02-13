using System.Reactive;

namespace Design.Patterns.Interpreter.Abstractions;

public abstract class Expression
{
    public abstract Unit Interpret(Unit context);
}
