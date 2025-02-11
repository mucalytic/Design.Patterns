using Design.Patterns.Visitor.Document.Formatter.Concretions.Elements;
using Design.Patterns.Visitor.Document.Formatter.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Visitor.Document.Formatter.Concretions.Visitors;

public class Markdown(ITestOutputHelper helper) : IVisitor
{
    public void Visit(Title title) =>
        helper.WriteLine($"Printed {nameof(Title)} ({title.Text}) in {nameof(Markdown)} format");

    public void Visit(Subtitle subtitle) =>
        helper.WriteLine($"Printed {nameof(Subtitle)} ({subtitle.Text}) in {nameof(Markdown)} format");

    public void Visit(Content content) =>
        helper.WriteLine($"Printed {nameof(Content)} ({content.Text}) in {nameof(Markdown)} format");
}
