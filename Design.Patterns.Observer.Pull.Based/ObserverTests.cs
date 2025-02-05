using Design.Patterns.Observer.Pull.Based.Models;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Observer.Pull.Based;

public class ObserverTests
{
    [Fact]
    public async Task AllAttachedObserversReceiveNotification_WhenSubjectSendsNotification()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var subject = new ConcreteSubject(helper);

        // act
        subject.Attach(new ConcreteObserver(helper, subject));
        subject.Attach(new ConcreteObserver(helper, subject));
        subject.Attach(new ConcreteObserver(helper, subject));
        subject.SetState("1");
        await Task.Delay(TimeSpan.FromSeconds(1));
        subject.SetState("2");

        // assert
        helper.Received(3).WriteLine("Observer reacted to state 1");
        helper.Received(3).WriteLine("Observer reacted to state 2");
    }
}
