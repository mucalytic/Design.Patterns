using Design.Patterns.Visitor.Document.Formatter.Concretions.Elements;

namespace Design.Patterns.Visitor.Document.Formatter.Interfaces;

public interface IVisitor
{
    void VisitTitle(Title title);
    void VisitSubtitle(Subtitle subtitle);
    void VisitContent(Content content);
}
