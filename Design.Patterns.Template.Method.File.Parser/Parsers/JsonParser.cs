using Design.Patterns.Template.Method.File.Parser.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Template.Method.File.Parser.Parsers;

public class JsonParser(
    ITestOutputHelper helper,
    IJsonSerialiser jsonSerialiser,
    IDateTimeProvider dateTimeProvider,
    IFileSystemProvider fileSystemProvider) :
    FileParser(helper, dateTimeProvider, fileSystemProvider)
{
    protected override Dictionary<string, string> ParseContent(string content) =>
        jsonSerialiser.Deserialise<Dictionary<string, string>>(content) ?? new Dictionary<string, string>();
}
