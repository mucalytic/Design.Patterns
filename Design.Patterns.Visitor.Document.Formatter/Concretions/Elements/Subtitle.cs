using Design.Patterns.Visitor.Document.Formatter.Interfaces;

namespace Design.Patterns.Visitor.Document.Formatter.Concretions.Elements;

public class Subtitle : IElement
{
    private string _text = string.Empty;
    
    public void SetText(string text) =>
        _text = text;

    public void Accept(IVisitor visitor) =>
        visitor.VisitSubtitle(this);
}
