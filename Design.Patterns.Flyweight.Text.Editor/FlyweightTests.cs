using Design.Patterns.Flyweight.Text.Editor.Clients;
using Design.Patterns.Flyweight.Text.Editor.Factories;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Flyweight.Text.Editor;

public class FlyweightTests
{
    [Fact]
    public void Editor_ShouldOnlyCreateGlyphsWithTheSameIntrinsicStateOnce()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var factory = new GlyphFactory(helper);
        var editor = new DocumentEditor(helper, factory);

        // act
        editor.InsertCharacter('a', "Arial",  0, 0, 12, "Black");
        editor.InsertCharacter('a', "Arial", 13, 0, 12, "Black");
        editor.InsertCharacter('r', "Arial", 26, 0, 12, "Black");
        editor.InsertCharacter('o', "Arial", 39, 0, 12, "Black");
        editor.InsertCharacter('n', "Arial", 52, 0, 12, "Black");
        editor.RenderDocument();
        
        // assert
        helper.Received(1).WriteLine("Creating new glyph 'a' with Arial");
    }
}
