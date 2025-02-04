using FluentAssertions;

namespace Design.Patterns.Naive.Singleton;

public class NaiveSingletonTests
{
    [Fact]
    public void Test()
    {
        // act
        var singleton1 = Singleton.Instance;
        var singleton2 = Singleton.Instance;
        
        // assert
        singleton1.Should().Be(singleton2);
    }
}
