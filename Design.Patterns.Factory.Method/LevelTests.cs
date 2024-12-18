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
        Level level = new CaveLevel();
        
        // act
        IEnemy enemy = level.CreateEnemy();

        // assert
        enemy.Should().BeOfType<Goblin>();
    }
    
    [Fact]
    public void HauntedHouseLevelCreatesGhost()
    {
        // arrange
        Level level = new HauntedHouseLevel();
        
        // act
        IEnemy enemy = level.CreateEnemy();

        // assert
        enemy.Should().BeOfType<Ghost>();
    }
}
