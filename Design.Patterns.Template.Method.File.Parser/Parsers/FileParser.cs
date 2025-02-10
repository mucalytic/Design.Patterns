using Design.Patterns.Template.Method.File.Parser.Interfaces;
using System.Globalization;
using Xunit.Abstractions;

namespace Design.Patterns.Template.Method.File.Parser.Parsers;

public abstract class FileParser(
    ITestOutputHelper helper,
    IDateTimeProvider dateTimeProvider,
    IFileSystemProvider fileSystemProvider)
{
    public Dictionary<string, string> ParseFile(string path)
    {
        LogOperation("Validating the file");
        ValidateFile(path);
        
        LogOperation("Loading the file");
        var content = fileSystemProvider.ReadAllText(path);
        
        LogOperation("Parsing the content");
        var data = ParseContent(content);
        
        LogOperation("Enriching the data");
        EnrichData(data);

        LogOperation("Validating the data");
        ValidateData(data);

        return data;
    }

    protected virtual void LogOperation(string message) =>
        helper.WriteLine($"{dateTimeProvider.UtcNow:HH:mm:ss}: {message}");

    protected virtual void EnrichData(Dictionary<string, string> data) =>
        data["ParsedAt"] = dateTimeProvider.UtcNow.ToString(CultureInfo.InvariantCulture);

    protected virtual void ValidateData(Dictionary<string, string> data) { }

    protected abstract Dictionary<string, string> ParseContent(string content);
    
    private void ValidateFile(string path)
    {
        if (!fileSystemProvider.FileExists(path))
        {
            throw new FileNotFoundException($"File {path} does not exist");
        }
        if (fileSystemProvider.FileSize(path) == 0)
        {
            throw new Exception($"File {path} has zero bytes");
        }
    }
}
