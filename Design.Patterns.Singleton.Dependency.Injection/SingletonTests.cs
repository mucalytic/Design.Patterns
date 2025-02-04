using Microsoft.Extensions.DependencyInjection;
using FluentAssertions;

namespace Design.Patterns.Singleton.Dependency.Injection;

public class SingletonTests
{
    [Fact]
    public void TwoReferencesToSingletonLogger_ShouldBeTheSameLogger()
    {
        // arrange
        var services = new ServiceCollection();
        services.AddSingleton<Logger>();

        // act
        var provider = services.BuildServiceProvider();
        var logger1 = provider.GetRequiredService<Logger>();
        var logger2 = provider.GetRequiredService<Logger>();
        
        // assert
        logger1.Should().Be(logger2);
    }

    [Fact]
    public void SingletonLogger_IsThreadSafe()
    {
        // arrange
        var services = new ServiceCollection();
        var loggers = new List<Logger>();
        services.AddSingleton<Logger>();
        
        // act
        var provider = services.BuildServiceProvider();
        Parallel.For(0, 10, _ => loggers.Add(provider.GetRequiredService<Logger>()));
        
        // assert
        loggers.Distinct().Should().HaveCount(1);
    }
}
