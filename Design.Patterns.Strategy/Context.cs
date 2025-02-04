using Design.Patterns.Strategy.Interfaces;

namespace Design.Patterns.Strategy;

public class Context
{
    private IStrategy? _strategy;

    public void SetStrategy(IStrategy strategy) => _strategy = strategy;

    public void ExecuteStrategy() => _strategy?.Execute();
}
