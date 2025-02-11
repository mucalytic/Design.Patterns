using Design.Patterns.Visitor.Document.Formatter.Interfaces;

namespace Design.Patterns.Visitor.Document.Formatter.Concretions.Elements;

public class Content : IElement
{
    private string _text = string.Empty;
    
    public void SetText(string text) =>
        _text = text;

    public void Accept(IVisitor visitor) =>
        visitor.Visit(this);
}
