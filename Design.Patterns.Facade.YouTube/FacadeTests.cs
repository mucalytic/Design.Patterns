using Xunit.Abstractions;
using FluentAssertions;
using NSubstitute;

namespace Design.Patterns.Facade.YouTube;

public class FacadeTests
{
    [Fact]
    public async Task Facade_CastsYouTubeVideoToDevice()
    {
        // arrange
        var videoId = Guid.NewGuid();
        var deviceId = Guid.NewGuid();
        var helper = Substitute.For<ITestOutputHelper>();
        var facade = new CastingFacade(new DeviceExplorer(helper));

        // act
        var action = async () => await facade.CastAsync(deviceId, videoId);

        // assert
        await action.Should().NotThrowAsync();
        helper.Received(1).WriteLine($"Launching app: {Constants.AppId}");
        helper.Received(1).WriteLine($"Getting device with id: {deviceId}");
        helper.Received(1).WriteLine("TV is off!");
        helper.Received(1).WriteLine("Turning on TV");
        helper.Received(1).WriteLine($"Playing video: {videoId}");
    }
}
