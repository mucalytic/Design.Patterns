using Design.Patterns.Facade.YouTube.Interfaces;

namespace Design.Patterns.Facade.YouTube;

public class SmartTvDevice : IDevice
{
    public Task<Connection> ConnectAsync() =>
        Task.FromException<Connection>(new Exception("TV is off!"));

    public async Task<Connection> TurnOnAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
        return new Connection();
    }
}
