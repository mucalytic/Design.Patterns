using Design.Patterns.Visitor.Concretions.Elements;
using Design.Patterns.Visitor.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Visitor.Concretions.Visitors;

public class Visitor2(ITestOutputHelper helper) : IVisitor
{
    public void Visit(Element1 element) =>
        helper.WriteLine($"{nameof(Visitor2)} visited {element.Operation1()}");

    public void Visit(Element2 element) =>
        helper.WriteLine($"{nameof(Visitor2)} visited {element.Operation2()}");
}
