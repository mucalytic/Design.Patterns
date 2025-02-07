using Design.Patterns.State.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.State.States;

public class ConcreteStateA(ITestOutputHelper helper) : IState
{
    public void Handle(Context context)
    {
        helper.WriteLine($"{nameof(ConcreteStateA)}.{nameof(Handle)}");
        context.SetState(new ConcreteStateB(helper));
    }
}
