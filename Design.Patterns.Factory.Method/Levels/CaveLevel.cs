using Design.Patterns.Factory.Method.Enemies;

namespace Design.Patterns.Factory.Method.Levels;

public class CaveLevel : Level
{
    public override IEnemy CreateEnemy() => new Goblin();
}
