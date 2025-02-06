using Design.Patterns.Facade.YouTube.Interfaces;

namespace Design.Patterns.Facade.YouTube;

public class Connection
{
    public Task<IApp> LaunchAppAsync(string appId) => Task.FromResult<IApp>(new YouTubeApp());
}
