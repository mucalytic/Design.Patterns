namespace Design.Patterns.Template.Method.File.Parser.Interfaces;

public interface IFileSystem
{
    bool FileExists(string path);
    long FileSize(string path);
    string ReadAllText(string path);
}
