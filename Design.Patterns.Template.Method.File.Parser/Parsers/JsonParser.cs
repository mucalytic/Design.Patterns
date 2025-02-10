using Design.Patterns.Template.Method.File.Parser.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Template.Method.File.Parser.Parsers;

public class JsonParser(
    ITestOutputHelper helper,
    IFileSystem fileSystem,
    IJsonSerialiser jsonSerialiser,
    IDateTimeProvider dateTimeProvider) :
    FileParser(helper, fileSystem, dateTimeProvider)
{
    public override Dictionary<string, string> ParseContent(string content) =>
        jsonSerialiser.Deserialise<Dictionary<string, string>>(content);
}
