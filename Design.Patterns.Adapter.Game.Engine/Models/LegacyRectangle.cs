namespace Design.Patterns.Adapter.Game.Engine.Models;

public class LegacyRectangle(int left, int top, int right, int bottom)
{
    private int _top    = top;
    private int _left   = left;
    private int _right  = right;
    private int _bottom = bottom;

    public int CalculateArea() =>
        (_right - _left) * (_bottom - _top);

    public int CalculatePerimeter() =>
        2 * (_right - _left) + 2 * (_bottom - _top);

    public void Shift(int horizontal, int vertical)
    {
        _top    += vertical;
        _left   += horizontal;
        _right  += horizontal;
        _bottom += vertical;
    }
}
