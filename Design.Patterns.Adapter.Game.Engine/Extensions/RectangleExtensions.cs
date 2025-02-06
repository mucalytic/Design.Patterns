using Design.Patterns.Adapter.Game.Engine.Interfaces;

namespace Design.Patterns.Adapter.Game.Engine.Extensions;

public static class RectangleExtensions
{
    public static void Center(this IRectangle rectangle) =>
        rectangle.Move(0, 0);
}
