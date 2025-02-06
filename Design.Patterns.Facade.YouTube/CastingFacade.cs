namespace Design.Patterns.Facade.YouTube;

public class CastingFacade(DeviceExplorer deviceExplorer)
{
    public async Task CastAsync(Guid deviceId, Guid videoId)
    {
        var device = await deviceExplorer.GetAsync(deviceId);
        if (device is not SmartTvDevice smartTvDevice)
        {
            throw new Exception("Smart TV not found");
        }
        Connection connection;
        try
        {
            connection = await smartTvDevice.ConnectAsync();
        }
        catch (Exception)
        {
            connection = await smartTvDevice.TurnOnAsync();
        }
        var app = await connection.LaunchAppAsync(Constants.AppId);
        if (app is not YouTubeApp youtubeApp)
        {
            throw new Exception("Failed to open YouTube app");
        }
        await youtubeApp.PlayAsync(videoId);
    }
}

