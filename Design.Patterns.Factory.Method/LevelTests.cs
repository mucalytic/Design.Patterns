using Design.Patterns.Factory.Method.Enemies;
using Design.Patterns.Factory.Method.Levels;
using FluentAssertions;

namespace Design.Patterns.Factory.Method;

public class LevelTests
{
    [Fact]
    public void CaveLevelCreatesGoblin()
    {
        // arrange
        var level = new CaveLevel();
        
        // act
        var enemy = level.CreateEnemy();

        // assert
        enemy.Should().BeOfType<Goblin>();
    }
    
    [Fact]
    public void HauntedHouseLevelCreatesGhost()
    {
        // arrange
        var level = new HauntedHouseLevel();
        
        // act
        var enemy = level.CreateEnemy();

        // assert
        enemy.Should().BeOfType<Ghost>();
    }
}
