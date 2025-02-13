using Design.Patterns.Interpreter.Maths.Concretions;
using FluentAssertions;

namespace Design.Patterns.Interpreter.Maths;

public class InterpreterTests
{
    [Fact]
    public void InterpretingExpressionOfIntegerBasedMathematicalOperation_ShouldReturnCorrectResult()
    {
        // arrange
        var expression =
            new AddExpression<int>(
                left: new NumberExpression<int>(1),
                right: new MultiplyExpression<int>(
                    left: new NumberExpression<int>(2),
                    right: new NumberExpression<int>(3)));

        // act
        var result = expression.Interpret();
        
        // assert
        result.Should().Be(7);
    }

    [Fact]
    public void InterpretingExpressionOfDecimalBasedMathematicalOperation_ShouldReturnCorrectResult()
    {
        // arrange
        var expression =
            new AddExpression<decimal>(
                left: new NumberExpression<decimal>(4.5m),
                right: new MultiplyExpression<decimal>(
                    left: new NumberExpression<decimal>(3.25m),
                    right: new NumberExpression<decimal>(15.75m)));

        // act
        var result = expression.Interpret();
        
        // assert
        result.Should().Be(55.6875m);
    }
}
