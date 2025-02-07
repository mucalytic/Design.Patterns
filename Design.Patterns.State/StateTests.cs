using Design.Patterns.State.States;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.State;

public class StateTests
{
    [Fact]
    public void Context_SwitchesBetweenStates_WhenRequestsAreMade()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var context = new Context(new ConcreteStateA(helper));
        
        // act
        context.Request();
        context.Request();
        context.Request();
        
        // assert
        helper.Received(2).WriteLine($"{nameof(ConcreteStateA)}.{nameof(ConcreteStateA.Handle)}");
        helper.Received(1).WriteLine($"{nameof(ConcreteStateB)}.{nameof(ConcreteStateB.Handle)}");
    }
}
