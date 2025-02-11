namespace Design.Patterns.Visitor.Interfaces;

public interface IElement
{
    void Accept(IVisitor visitor);
}
