namespace Design.Patterns.Template.Method.File.Parser.Interfaces;

public interface IJsonSerialiser
{
    T? Deserialise<T>(string json);
}
