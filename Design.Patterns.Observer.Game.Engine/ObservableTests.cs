using Design.Patterns.Observer.Game.Engine.Observers;
using Design.Patterns.Observer.Game.Engine.Subjects;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Observer.Game.Engine;

public class ObservableTests
{
    [Fact]
    public void Observers_DisplayCorrectUpdates_FromSubject()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var player = new Player(helper);
        var scoreUi = new ScoreUi(helper, player);
        var healthBarUi = new HealthBarUi(helper, player);
        var gameOverScreen = new GameOverScreen(helper, player);
        player.Attach(gameOverScreen);
        player.Attach(healthBarUi);
        player.Attach(scoreUi);
        
        // act
        player.SetHealth(100);
        player.SetScore(0);
        player.SetScore(10);
        player.SetHealth(90);
        player.SetScore(20);
        player.SetHealth(80);
        player.SetScore(30);
        player.SetHealth(10);
        player.SetScore(25);
        player.SetHealth(0);
        
        // assert
        helper.Received(1).WriteLine("Health: 100");
        helper.Received(1).WriteLine("Health: 90");
        helper.Received(1).WriteLine("Health: 80");
        helper.Received(1).WriteLine("Health: 10");
        helper.Received(1).WriteLine("Health: 0");
        helper.Received(1).WriteLine("Score: 0");
        helper.Received(1).WriteLine("Score: 10");
        helper.Received(1).WriteLine("Score: 20");
        helper.Received(1).WriteLine("Score: 30");
        helper.Received(1).WriteLine("Score: 25");
        helper.Received(1).WriteLine("GAME OVER!");
    }
}
