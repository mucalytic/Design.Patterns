using Design.Patterns.Template.Method.File.Parser.Interfaces;
using System.Text.Json;

namespace Design.Patterns.Template.Method.File.Parser;

public class JsonSerialiser : IJsonSerialiser
{
    public T? Deserialise<T>(string json) =>
        JsonSerializer.Deserialize<T>(json);
}
