using Design.Patterns.Mediator.Concretions;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Mediator;

public class MediatorTests
{
    [Fact]
    public void Colleagues_ReceiveMessagesFromEachOther()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var colleague1 = new Colleague1(helper);
        var colleague2 = new Colleague2(helper);
        var mediator = new Concretions.Mediator(helper, colleague1, colleague2);
        colleague1.SetMediator(mediator);
        colleague2.SetMediator(mediator);

        // act
        colleague1.Operation1();
        colleague2.Operation2();

        // assert
        helper.Received(1).WriteLine("Colleague1 did Operation1");
        helper.Received(1).WriteLine("Mediator notified by Colleague1: Colleague1 did Operation1");
        helper.Received(1).WriteLine("Colleague2 received Colleague1 did Operation1");
        helper.Received(1).WriteLine("Colleague2 did Operation2");
        helper.Received(1).WriteLine("Mediator notified by Colleague2: Colleague2 did Operation2");
        helper.Received(1).WriteLine("Colleague1 received Colleague2 did Operation2");
    }
}
