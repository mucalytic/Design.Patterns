using Design.Patterns.Facade.YouTube.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Facade.YouTube;

public class YouTubeApp(ITestOutputHelper helper) : IApp
{
    public Task PlayAsync(Guid videoId)
    {
        helper.WriteLine($"Playing video: {videoId}");
        return Task.CompletedTask;
    }
}
