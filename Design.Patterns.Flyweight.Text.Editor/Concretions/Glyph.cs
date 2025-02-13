using Design.Patterns.Flyweight.Text.Editor.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Flyweight.Text.Editor.Concretions;

public class Glyph : IGlyph
{
    private readonly char _character;
    private readonly string _fontFamily;
    private readonly ITestOutputHelper _helper;
    
    public Glyph(ITestOutputHelper helper, char character, string fontFamily)
    {
        _fontFamily = fontFamily;
        _character = character;
        _helper = helper;
        _helper.WriteLine($"Creating new glyph '{_character}' with {_fontFamily}");
    }

    // we'd actually render the glyph to the screen using the extrinsic state 
    public void Render(int x, int y, int size, string colour) =>
        _helper.WriteLine($"Rendering {colour} '{_character}' from family {_fontFamily} at ({x}, {y} x {size})");
}
