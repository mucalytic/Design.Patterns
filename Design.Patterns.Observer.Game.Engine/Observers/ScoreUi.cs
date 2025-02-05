using Design.Patterns.Observer.Game.Engine.Interfaces;
using Design.Patterns.Observer.Game.Engine.Subjects;
using Xunit.Abstractions;

namespace Design.Patterns.Observer.Game.Engine.Observers;

public class ScoreUi(ITestOutputHelper helper, Player player) : IGameObserver
{
    public void UpdateHealth() { }

    public void UpdateScore()
    {
        var score = player.GetScore();
        helper.WriteLine($"Score: {score}");
    }
}
