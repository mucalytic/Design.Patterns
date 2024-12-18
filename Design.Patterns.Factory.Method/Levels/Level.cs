using Design.Patterns.Factory.Method.Enemies;

namespace Design.Patterns.Factory.Method.Levels;

public abstract class Level
{
    public abstract IEnemy CreateEnemy();
}
