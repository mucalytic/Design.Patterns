using Design.Patterns.Visitor.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Visitor.Concretions.Elements;

public class Element2(ITestOutputHelper helper) : IElement
{
    public void Operation2() =>
        helper.WriteLine($"{nameof(Element2)} executed {nameof(Operation2)}");

    public void Accept(IVisitor visitor) =>
        visitor.Visit(this);
}
