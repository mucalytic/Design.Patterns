using Design.Patterns.Visitor.Concretions.Elements;
using Design.Patterns.Visitor.Interfaces;

namespace Design.Patterns.Visitor.Concretions.Visitors;

public class Visitor2 : IVisitor
{
    public void Visit(Element1 element) =>
        element.Operation1();

    public void Visit(Element2 element) =>
        element.Operation2();
}
