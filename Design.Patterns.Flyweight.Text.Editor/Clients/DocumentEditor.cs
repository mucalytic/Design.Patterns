using Design.Patterns.Flyweight.Text.Editor.Interfaces;
using Design.Patterns.Flyweight.Text.Editor.Factories;
using Xunit.Abstractions;

namespace Design.Patterns.Flyweight.Text.Editor.Clients;

public class DocumentEditor(ITestOutputHelper helper, GlyphFactory factory)
{
    private readonly List<(IGlyph Glyph, int X, int Y, int Size, string Colour)> _characters = [];
    
    public void InsertCharacter(char character, string fontFamily, int x, int y, int size, string colour)
    {
        helper.WriteLine($"Inserting {colour} '{character}' from family {fontFamily} at ({x}, {y} x {size})");
        var glyph = factory.GetGlyph(character, fontFamily);
        _characters.Add((glyph, x, y, size, colour));
    }

    public void RenderDocument()
    {
        helper.WriteLine("Rendering document:");
        foreach (var character in _characters)
        {
            character.Glyph.Render(character.X, character.Y, character.Size, character.Colour);
        }
    }
}
