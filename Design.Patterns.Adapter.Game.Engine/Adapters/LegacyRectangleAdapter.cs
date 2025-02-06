using Design.Patterns.Adapter.Game.Engine.Interfaces;
using Design.Patterns.Adapter.Game.Engine.Models;

namespace Design.Patterns.Adapter.Game.Engine.Adapters;

public class LegacyRectangleAdapter(LegacyRectangle legacyRectangle) : IRectangle
{
    public long GetArea() =>
        legacyRectangle.CalculateArea();

    public long GetPerimeter() =>
        legacyRectangle.CalculatePerimeter();

    public void Move(long dx, long dy)
    {
        if (dx < int.MinValue || dx > int.MaxValue || dy < int.MinValue || dy > int.MaxValue) return;
        legacyRectangle.Shift(Convert.ToInt32(dx), Convert.ToInt32(dy));
    }
}
