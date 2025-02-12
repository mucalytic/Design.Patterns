using Design.Patterns.Chain.Of.Responsibility.Concretions;
using NSubstitute;
using Xunit.Abstractions;

namespace Design.Patterns.Chain.Of.Responsibility;

public class ChainOfResponsibilityTests
{
    [Theory]
    [InlineData(["hello", 1])]
    [InlineData(["there", 2])]
    [InlineData(["world", 3])]
    public void CorrectHandler_ShouldHandleRequest_WhenCriteriaMatch(string input, int expected)
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var handler1 = new Handler1(helper);
        var handler2 = new Handler2(helper);
        var handler3 = new Handler3(helper);
        handler1.SetSuccessor(handler2);
        handler2.SetSuccessor(handler3);

        // act
        handler1.Handle(input);
        
        // assert
        helper.Received(1).WriteLine($"Handler{expected} handled request");
    }

    [Fact]
    public void NoHandler_ShouldHandleRequest_WhenNoCriteriaMatch()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var handler1 = new Handler1(helper);
        var handler2 = new Handler2(helper);
        var handler3 = new Handler3(helper);
        handler1.SetSuccessor(handler2);
        handler2.SetSuccessor(handler3);

        // act
        handler1.Handle("ugly");
        
        // assert
        helper.Received(0).WriteLine(Arg.Any<string>());
    }
}
