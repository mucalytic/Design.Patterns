using Design.Patterns.Visitor.Interfaces;

namespace Design.Patterns.Visitor.Concretions.Elements;

public class Element2 : IElement
{
    public void Operation2() { }

    public void Accept(IVisitor visitor) =>
        visitor.VisitElement2(this);
}
