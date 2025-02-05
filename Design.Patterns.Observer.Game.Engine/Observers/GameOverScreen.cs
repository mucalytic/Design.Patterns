using Design.Patterns.Observer.Game.Engine.Interfaces;
using Design.Patterns.Observer.Game.Engine.Subjects;
using Xunit.Abstractions;

namespace Design.Patterns.Observer.Game.Engine.Observers;

public class GameOverScreen(ITestOutputHelper helper, Player player) : IGameObserver
{
    public void UpdateHealth()
    {
        var health = player.GetHealth();
        if (health <= 0)
        {
            helper.WriteLine("GAME OVER!");
        }
    }

    public void UpdateScore() { }
}
