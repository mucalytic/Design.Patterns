using Design.Patterns.Flyweight.Text.Editor.Concretions;
using Xunit.Abstractions;

namespace Design.Patterns.Flyweight.Text.Editor.Factories;

public class GlyphFactory(ITestOutputHelper helper)
{
    private readonly Dictionary<object, Glyph> _characters = new();
    
    public Glyph? GetGlyph(object key) =>
        _characters.GetValueOrDefault(key);

    public void Add(object intrinsicData, Glyph glyph)
    {
        if (_characters.TryAdd(intrinsicData, glyph)) return;
        helper.WriteLine($"Glyph with key {intrinsicData} is already added.");
    }
}
