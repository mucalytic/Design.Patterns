using Design.Patterns.Flyweight.Text.Editor.Factories;
using System.Reactive;

namespace Design.Patterns.Flyweight.Text.Editor.Clients;

public class DocumentEditor(GlyphFactory factory)
{
    public void InsertCharacter() { }
    public void RenderDocument(Unit graphics) { }
}
