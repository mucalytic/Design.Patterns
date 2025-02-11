using Design.Patterns.Visitor.Document.Formatter.Interfaces;

namespace Design.Patterns.Visitor.Document.Formatter.Concretions.Elements;

public class Subtitle(string text) : IElement
{
    public string Text { get; } = text;

    public void Accept(IVisitor visitor) =>
        visitor.Visit(this);
}
