namespace Design.Patterns.Adapter.Game.Engine.Interfaces;

public interface IRectangle
{
    long GetArea();
    long GetPerimeter();
    void Move(long dx, long dy);
}
