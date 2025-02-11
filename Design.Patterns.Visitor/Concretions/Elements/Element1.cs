using Design.Patterns.Visitor.Interfaces;

namespace Design.Patterns.Visitor.Concretions.Elements;

public class Element1 : IElement
{
    public void Operation1() { }

    public void Accept(IVisitor visitor) =>
        visitor.VisitElement1(this);
}
