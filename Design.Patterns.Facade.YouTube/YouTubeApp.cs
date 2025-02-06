using Design.Patterns.Facade.YouTube.Interfaces;

namespace Design.Patterns.Facade.YouTube;

public class YouTubeApp : IApp
{
    public Task PlayAsync(Guid videoId) => Task.CompletedTask;
}
