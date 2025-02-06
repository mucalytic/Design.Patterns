using Design.Patterns.Facade.YouTube.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Facade.YouTube;

public class Connection(ITestOutputHelper helper)
{
    public Task<IApp> LaunchAppAsync(string appId)
    {
        helper.WriteLine($"Launching app: {appId}");
        return Task.FromResult<IApp>(new YouTubeApp(helper));
    }
}
