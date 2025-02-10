using Design.Patterns.Template.Method.File.Parser.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Template.Method.File.Parser.Parsers;

public class CsvParser(
    ITestOutputHelper helper,
    IFileSystem fileSystem,
    IDateTimeProvider dateTimeProvider) :
    FileParser(helper, fileSystem, dateTimeProvider)
{
    public override Dictionary<string, string> ParseContent(string content)
    {
        var result = new Dictionary<string, string>();
        foreach (var row in content.Split(Environment.NewLine))
        {
            var parts = row.Split(',');
            result[parts[0]] = parts[1];
        }
        return result;
    }

    public override void EnrichData(Dictionary<string, string> data)
    {
        base.EnrichData(data);
        data["DataType"] = "CSV";
    }
}
