namespace Design.Patterns.Template.Method.File.Parser.Interfaces;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
