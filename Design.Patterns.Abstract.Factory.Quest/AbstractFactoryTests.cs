using Design.Patterns.Abstract.Factory.Quest.Factories;
using Design.Patterns.Abstract.Factory.Quest.Factories.CaveLevel;
using Design.Patterns.Abstract.Factory.Quest.Factories.HauntedHouseLevel;
using Design.Patterns.Abstract.Factory.Quest.Models.CaveLevel;
using Design.Patterns.Abstract.Factory.Quest.Models.HauntedHouseLevel;
using FluentAssertions;

namespace Design.Patterns.Abstract.Factory.Quest;

public class AbstractFactoryTests
{
    [Fact]
    public void ElementFactoryForCaveLevel_CreatesElementsForCaveLevel()
    {
        // arrange
        LevelElementFactory factory = new CaveLevelElementFactory();
        
        // act
        var enemy = factory.CreateEnemy();
        var weapon = factory.CreateWeapon();
        var powerUp = factory.CreatePowerUp();

        // assert
        enemy.Should().BeOfType<Goblin>();
        weapon.Should().BeOfType<Axe>();
        powerUp.Should().BeOfType<Crystal>();
    }

    [Fact]
    public void ElementFactoryForHauntedHouseLevel_CreatesElementsForHauntedHouseLevel()
    {
        // arrange
        LevelElementFactory factory = new HauntedHouseLevelFactory();
        
        // act
        var enemy = factory.CreateEnemy();
        var weapon = factory.CreateWeapon();
        var powerUp = factory.CreatePowerUp();

        // assert
        enemy.Should().BeOfType<Ghost>();
        weapon.Should().BeOfType<Wand>();
        powerUp.Should().BeOfType<Orb>();
    }
}
