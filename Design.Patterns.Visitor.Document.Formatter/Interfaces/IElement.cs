namespace Design.Patterns.Visitor.Document.Formatter.Interfaces;

public interface IElement
{
    void Accept(IVisitor visitor);
}
