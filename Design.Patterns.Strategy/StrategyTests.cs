using Design.Patterns.Strategy.Strategies;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Strategy;

public class StrategyTests
{
    [Fact]
    public void Context_ShouldCallConcreteStrategyA()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var context = new Context();
        
        // act
        context.SetStrategy(new ConcreteStrategyA(helper));
        context.ExecuteStrategy();
        
        // assert
        helper.Received(1).WriteLine($"{nameof(ConcreteStrategyA)} executed");
    }
    
    [Fact]
    public void Context_ShouldCallConcreteStrategyB()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var context = new Context();
        
        // act
        context.SetStrategy(new ConcreteStrategyB(helper));
        context.ExecuteStrategy();
        
        // assert
        helper.Received(1).WriteLine($"{nameof(ConcreteStrategyB)} executed");
    }    
    [Fact]
    public void Context_ShouldCallConcreteStrategyC()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var context = new Context();
        
        // act
        context.SetStrategy(new ConcreteStrategyC(helper));
        context.ExecuteStrategy();
        
        // assert
        helper.Received(1).WriteLine($"{nameof(ConcreteStrategyC)} executed");
    }
}
