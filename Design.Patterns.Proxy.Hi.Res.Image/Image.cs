using Design.Patterns.Proxy.Hi.Res.Image.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Proxy.Hi.Res.Image;

public class Image(ITestOutputHelper helper, string name) : IImage
{
    public void Display() =>
        helper.WriteLine($"Displaying {name}");

    public void Dispose() { }
}
