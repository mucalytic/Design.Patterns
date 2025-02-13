using Design.Patterns.Interpreter.Search.Query.Concretions;
using FluentAssertions;

namespace Design.Patterns.Interpreter.Search.Query;

public class InterpreterTests
{
    private readonly List<string> _context = ["hello", "there", "world", "funny"];
    
    [Fact]
    public void Interpreter_ShouldMatchWordsThatAreHello()
    {
        // arrange
        var hello = new WordExpression(word: "hello");

        // act
        var result = hello.Interpret(_context);

        // assert
        result.Should().BeEquivalentTo("hello");
    }

    [Fact]
    public void Interpreter_ShouldMatchWordsThatAreNotHello()
    {
        // arrange
        var hello = new NotExpression(word: "hello");

        // act
        var result = hello.Interpret(_context);

        // assert
        result.Should().BeEquivalentTo("there", "world", "funny");
    }

    [Fact]
    public void Interpreter_ShouldMatchWordsThatContainHe()
    {
        // arrange
        var hello = new ContainsExpression(value: "he");

        // act
        var result = hello.Interpret(_context);

        // assert
        result.Should().BeEquivalentTo("hello", "there");
    }
    
    [Fact]
    public void Interpreter_ShouldMatchWordsThatContainHeAndAreNotHello()
    {
        // arrange
        var hello =
            new AndExpression(
                left: new NotExpression(word: "hello"),
                right: new ContainsExpression(value: "he"));

        // act
        var result = hello.Interpret(_context);

        // assert
        result.Should().BeEquivalentTo("there");
    }
}
