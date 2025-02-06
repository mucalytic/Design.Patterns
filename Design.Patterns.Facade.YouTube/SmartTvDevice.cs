using Design.Patterns.Facade.YouTube.Interfaces;
using Xunit.Abstractions;

namespace Design.Patterns.Facade.YouTube;

public class SmartTvDevice(ITestOutputHelper helper) : IDevice
{
    public Task<Connection> ConnectAsync()
    {
        helper.WriteLine("TV is off!");
        return Task.FromException<Connection>(new Exception());
    }

    public async Task<Connection> TurnOnAsync()
    {
        helper.WriteLine("Turning on TV");
        await Task.Delay(TimeSpan.FromSeconds(2));
        return new Connection(helper);
    }
}
