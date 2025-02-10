using Design.Patterns.Template.Method.File.Parser.Interfaces;

namespace Design.Patterns.Template.Method.File.Parser.Providers;

public class FileSystemProvider : IFileSystemProvider
{
    public bool FileExists(string path) =>
        System.IO.File.Exists(path);

    public long FileSize(string path) =>
        new FileInfo(path).Length;

    public string ReadAllText(string path) =>
        System.IO.File.ReadAllText(path);
}
