using Design.Patterns.Abstract.Factory.Quest.Models.HauntedHouseLevel;
using Design.Patterns.Abstract.Factory.Quest.Interfaces;

namespace Design.Patterns.Abstract.Factory.Quest.Factories.HauntedHouseLevel;

public class HauntedHouseLevelFactory : LevelElementFactory
{
    public override IEnemy CreateEnemy() =>
        new Ghost();

    public override IWeapon CreateWeapon() =>
        new Wand();

    public override IPowerUp CreatePowerUp() =>
        new Orb();
}
