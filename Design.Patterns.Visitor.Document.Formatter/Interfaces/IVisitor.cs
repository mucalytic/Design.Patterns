using Design.Patterns.Visitor.Document.Formatter.Concretions.Elements;

namespace Design.Patterns.Visitor.Document.Formatter.Interfaces;

public interface IVisitor
{
    void Visit(Title title);
    void Visit(Subtitle subtitle);
    void Visit(Content content);
}
