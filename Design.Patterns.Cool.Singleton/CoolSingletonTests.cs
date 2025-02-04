using FluentAssertions;

namespace Design.Patterns.Cool.Singleton;

public class CoolSingletonTests
{
    [Fact]
    public void TwoReferencesToSingletonInstance_ShouldBeTheSameSingleton()
    {
        // act
        var singleton1 = Singleton.Instance;
        var singleton2 = Singleton.Instance;
        
        // assert
        singleton1.Should().Be(singleton2);
    }
    
    [Fact]
    public void Singleton_IsThreadSafe()
    {
        // arrange
        var singletons = new List<Singleton>();
        
        // act
        Parallel.For(0, 10, _ => singletons.Add(Singleton.Instance));
        
        // assert
        singletons.Distinct().Should().HaveCount(1);
    }
}
