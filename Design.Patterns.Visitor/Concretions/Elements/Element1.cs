using Design.Patterns.Visitor.Interfaces;

namespace Design.Patterns.Visitor.Concretions.Elements;

public class Element1 : IElement
{
    public string Operation1() =>
        $"{nameof(Element1)} executed {nameof(Operation1)}";

    public void Accept(IVisitor visitor) =>
        visitor.Visit(this);
}
