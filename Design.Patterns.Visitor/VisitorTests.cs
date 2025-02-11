using Design.Patterns.Visitor.Concretions.Elements;
using Design.Patterns.Visitor.Concretions.Visitors;
using NSubstitute;
using Xunit.Abstractions;

namespace Design.Patterns.Visitor;

public class VisitorTests
{
    [Fact]
    public void ElementsAcceptVisitorsAndVisitors_ShouldCallOperationsOnElements()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var element1 = new Element1(helper);
        var element2 = new Element2(helper);
        var visitor1 = new Visitor1();
        var visitor2 = new Visitor2();

        // act
        element1.Accept(visitor1);
        element2.Accept(visitor1);
        element1.Accept(visitor2);
        element2.Accept(visitor2);
        
        // assert
        helper.Received(2).WriteLine($"{nameof(Element1)} executed {nameof(Element1.Operation1)}");
        helper.Received(2).WriteLine($"{nameof(Element2)} executed {nameof(Element2.Operation2)}");
    }
}
