using Design.Patterns.State.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.State.States;

public class ConcreteStateB(ITestOutputHelper helper) : IState
{
    public void Handle(Context context)
    {
        helper.WriteLine($"{nameof(ConcreteStateB)}.{nameof(Handle)}");
        context.SetState(new ConcreteStateA(helper));
    }
}
