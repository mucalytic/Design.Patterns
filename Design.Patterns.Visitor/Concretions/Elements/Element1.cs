using Design.Patterns.Visitor.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Visitor.Concretions.Elements;

public class Element1(ITestOutputHelper helper) : IElement
{
    public void Operation1() =>
        helper.WriteLine($"{nameof(Element1)} executed {nameof(Operation1)}");

    public void Accept(IVisitor visitor) =>
        visitor.Visit(this);
}
