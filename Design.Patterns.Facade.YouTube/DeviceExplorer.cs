using Design.Patterns.Facade.YouTube.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Facade.YouTube;

public class DeviceExplorer(ITestOutputHelper helper)
{
    public Task<IDevice> GetAsync(Guid deviceId)
    {
        helper.WriteLine($"Getting device with id: {deviceId}");
        return Task.FromResult<IDevice>(new SmartTvDevice(helper));
    }
}
