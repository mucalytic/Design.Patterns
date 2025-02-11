using Design.Patterns.Visitor.Concretions.Elements;
using Design.Patterns.Visitor.Interfaces;

namespace Design.Patterns.Visitor.Concretions.Visitors;

public class Visitor1 : IVisitor
{
    public void VisitElement1(Element1 element)
    {
        throw new NotImplementedException();
    }

    public void VisitElement2(Element2 element)
    {
        throw new NotImplementedException();
    }
}
