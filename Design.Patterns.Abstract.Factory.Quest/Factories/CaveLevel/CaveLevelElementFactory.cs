using Design.Patterns.Abstract.Factory.Quest.Models.CaveLevel;
using Design.Patterns.Abstract.Factory.Quest.Interfaces;

namespace Design.Patterns.Abstract.Factory.Quest.Factories.CaveLevel;

public class CaveLevelElementFactory : LevelElementFactory
{
    public override IEnemy CreateEnemy() =>
        new Goblin();

    public override IWeapon CreateWeapon() =>
        new Axe();

    public override IPowerUp CreatePowerUp() =>
        new Crystal();
}
