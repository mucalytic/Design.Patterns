using Design.Patterns.Observer.Push.Based.Models;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Observer.Push.Based;

public class ObserverTests
{
    [Fact]
    public async Task AllAttachedObserversReceiveNotification_WhenSubjectSendsNotification()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var subject = new ConcreteSubject(helper);

        // act
        using var observer1 = new ConcreteObserver(helper, subject);
        using var observer2 = new ConcreteObserver(helper, subject);
        using var observer3 = new ConcreteObserver(helper, subject);
        
        subject.Attach(observer1);
        subject.Attach(observer2);
        subject.Attach(observer3);
        
        subject.Notify("1");
        await Task.Delay(TimeSpan.FromSeconds(1));
        subject.Notify("2");

        // assert
        helper.Received(3).WriteLine("Observer reacted to state 1");
        helper.Received(3).WriteLine("Observer reacted to state 2");
    }
}
