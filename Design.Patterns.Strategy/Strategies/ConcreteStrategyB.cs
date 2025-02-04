using Design.Patterns.Strategy.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Strategy.Strategies;

public class ConcreteStrategyB(ITestOutputHelper helper) : IStrategy
{
    public void Execute() =>
        helper.WriteLine($"{nameof(ConcreteStrategyB)} executed");
}
