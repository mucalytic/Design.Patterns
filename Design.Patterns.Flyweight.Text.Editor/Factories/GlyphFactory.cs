using Design.Patterns.Flyweight.Text.Editor.Concretions;
using Design.Patterns.Flyweight.Text.Editor.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Flyweight.Text.Editor.Factories;

public class GlyphFactory(ITestOutputHelper helper)
{
    private readonly Dictionary<(char Character, string FontFamily), IGlyph> _glyphMap = new();
    
    public IGlyph GetGlyph(char character, string fontFamily)
    {
        if (!_glyphMap.ContainsKey((character, fontFamily)))
        {
            _glyphMap[(character, fontFamily)] = new Glyph(helper, character, fontFamily);
        }
        return _glyphMap[(character, fontFamily)];
    }
}
