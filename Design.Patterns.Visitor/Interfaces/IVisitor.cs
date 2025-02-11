using Design.Patterns.Visitor.Concretions.Elements;

namespace Design.Patterns.Visitor.Interfaces;

public interface IVisitor
{
    void Visit(Element1 element);
    void Visit(Element2 element);
}
