using Design.Patterns.Facade.YouTube.Interfaces;

namespace Design.Patterns.Facade.YouTube;

public class DeviceExplorer
{
    public Task<IDevice> GetAsync(Guid deviceId) => Task.FromResult<IDevice>(new SmartTvDevice());
}
