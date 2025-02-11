using Design.Patterns.Visitor.Document.Formatter.Concretions.Elements;
using Design.Patterns.Visitor.Document.Formatter.Interfaces;

namespace Design.Patterns.Visitor.Document.Formatter.Concretions.Visitors;

public class Text : IVisitor
{
    public void VisitTitle(Title title)
    {
        throw new NotImplementedException();
    }

    public void VisitSubtitle(Subtitle subtitle)
    {
        throw new NotImplementedException();
    }

    public void VisitContent(Content content)
    {
        throw new NotImplementedException();
    }
}
