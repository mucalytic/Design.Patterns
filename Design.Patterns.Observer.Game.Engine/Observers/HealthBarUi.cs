using Design.Patterns.Observer.Game.Engine.Interfaces;
using Design.Patterns.Observer.Game.Engine.Subjects;
using Xunit.Abstractions;

namespace Design.Patterns.Observer.Game.Engine.Observers;

public class HealthBarUi(ITestOutputHelper helper, Player player) : IGameObserver
{
    public void UpdateHealth()
    {
        var health = player.GetHealth();
        helper.WriteLine($"Health: {health}");
    }

    public void UpdateScore() { }
}
