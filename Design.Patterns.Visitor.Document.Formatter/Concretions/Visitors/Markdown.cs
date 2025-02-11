using Design.Patterns.Visitor.Document.Formatter.Concretions.Elements;
using Design.Patterns.Visitor.Document.Formatter.Interfaces;

namespace Design.Patterns.Visitor.Document.Formatter.Concretions.Visitors;

public class Markdown : IVisitor
{
    public void Visit(Title title)
    {
        throw new NotImplementedException();
    }

    public void Visit(Subtitle subtitle)
    {
        throw new NotImplementedException();
    }

    public void Visit(Content content)
    {
        throw new NotImplementedException();
    }
}
