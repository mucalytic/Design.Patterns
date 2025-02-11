using Design.Patterns.Visitor.Concretions.Elements;

namespace Design.Patterns.Visitor.Interfaces;

public interface IVisitor
{
    void VisitElement1(Element1 element);
    void VisitElement2(Element2 element);
}
