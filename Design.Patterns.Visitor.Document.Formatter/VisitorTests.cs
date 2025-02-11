using Design.Patterns.Visitor.Document.Formatter.Concretions.Elements;
using Design.Patterns.Visitor.Document.Formatter.Concretions.Visitors;
using Design.Patterns.Visitor.Document.Formatter.Interfaces;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Visitor.Document.Formatter;

public class VisitorTests
{
    [Fact]
    public void ElementsAcceptVisitorsAndVisitors_ShouldCallOperationsOnElements()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        List<IElement> elements =
        [
            new Title("The Visitor Design Pattern"),
            new Subtitle("Intent"),
            new Content("Represent an operation"),
            new Subtitle("Impact"),
            new Content("Immense")
        ];
        var markdown = new Markdown(helper);
        var text = new Text(helper);

        // act
        foreach (var element in elements)
        {
            element.Accept(markdown);
            element.Accept(text);
        }

        // assert
        helper.Received(1).WriteLine($"Printed {nameof(Subtitle)} (Intent) in {nameof(Text)} format");
        helper.Received(1).WriteLine($"Printed {nameof(Subtitle)} (Intent) in {nameof(Markdown)} format");
        helper.Received(1).WriteLine($"Printed {nameof(Subtitle)} (Impact) in {nameof(Text)} format");
        helper.Received(1).WriteLine($"Printed {nameof(Subtitle)} (Impact) in {nameof(Markdown)} format");
        helper.Received(1).WriteLine($"Printed {nameof(Content)} (Immense) in {nameof(Text)} format");
        helper.Received(1).WriteLine($"Printed {nameof(Content)} (Immense) in {nameof(Markdown)} format");
        helper.Received(1).WriteLine($"Printed {nameof(Content)} (Represent an operation) in {nameof(Text)} format");
        helper.Received(1).WriteLine($"Printed {nameof(Content)} (Represent an operation) in {nameof(Markdown)} format");
        helper.Received(1).WriteLine($"Printed {nameof(Title)} (The Visitor Design Pattern) in {nameof(Text)} format");
        helper.Received(1).WriteLine($"Printed {nameof(Title)} (The Visitor Design Pattern) in {nameof(Markdown)} format");
    }
}
