using Design.Patterns.Template.Method.File.Parser.Interfaces;
using System.Globalization;
using Xunit.Abstractions;

namespace Design.Patterns.Template.Method.File.Parser.Parsers;

public abstract class FileParser(ITestOutputHelper helper, IFileSystem fileSystem, IDateTimeProvider dateTimeProvider)
{
    public Dictionary<string, string> ParseFile(string path)
    {
        LogOperation("Validating the file");
        ValidateFile(path);
        
        LogOperation("Loading the file");
        var content = fileSystem.ReadAllText(path);
        
        LogOperation("Parsing the content");
        var data = ParseContent(content);
        
        LogOperation("Enriching the data");
        EnrichData(data);

        LogOperation("Validating the data");
        ValidateData(data);

        return data;
    }

    public virtual void LogOperation(string message) =>
        helper.WriteLine($"{dateTimeProvider.UtcNow:HH:mm:ss}: {message}");

    public virtual void EnrichData(Dictionary<string, string> data) =>
        data["ParsedAt"] = dateTimeProvider.UtcNow.ToString(CultureInfo.InvariantCulture);

    public virtual void ValidateData(Dictionary<string, string> data) { }

    public abstract Dictionary<string, string> ParseContent(string content);
    
    private void ValidateFile(string path)
    {
        if (!fileSystem.FileExists(path))
        {
            throw new FileNotFoundException($"File {path} does not exist");
        }
        if (fileSystem.FileSize(path) == 0)
        {
            throw new Exception($"File {path} has zero bytes");
        }
    }
}
