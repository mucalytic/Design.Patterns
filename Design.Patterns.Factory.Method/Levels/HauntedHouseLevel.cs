using Design.Patterns.Factory.Method.Enemies;

namespace Design.Patterns.Factory.Method.Levels;

public class HauntedHouseLevel : Level
{
    public override IEnemy CreateEnemy() => new Ghost();
}
