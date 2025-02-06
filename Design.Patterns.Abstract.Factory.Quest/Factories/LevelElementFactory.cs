using Design.Patterns.Abstract.Factory.Quest.Interfaces;

namespace Design.Patterns.Abstract.Factory.Quest.Factories;

public abstract class LevelElementFactory
{
    public abstract IEnemy CreateEnemy();
    public abstract IWeapon CreateWeapon();
    public abstract IPowerUp CreatePowerUp();
}
