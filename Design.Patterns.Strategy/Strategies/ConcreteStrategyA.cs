using Design.Patterns.Strategy.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Strategy.Strategies;

public class ConcreteStrategyA(ITestOutputHelper helper) : IStrategy
{
    public void Execute() =>
        helper.WriteLine($"{nameof(ConcreteStrategyA)} executed");
}
