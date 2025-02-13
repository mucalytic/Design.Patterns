namespace Design.Patterns.Flyweight.Text.Editor.Interfaces;

public interface IGlyph
{
    void Render(int x, int y, int size, string colour);
}
