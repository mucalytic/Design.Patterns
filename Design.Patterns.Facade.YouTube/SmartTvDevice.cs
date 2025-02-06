using Design.Patterns.Facade.YouTube.Interfaces;

namespace Design.Patterns.Facade.YouTube;

public class SmartTvDevice : IDevice
{
    public Task<Connection> ConnectAsync() => Task.FromResult(new Connection());
    public Task<Connection> TurnOnAsync() => Task.FromResult(new Connection());
}
