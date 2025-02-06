using FluentAssertions;

namespace Design.Patterns.Facade.YouTube;

public class FacadeTests
{
    [Fact]
    public async Task Facade_CastsYouTubeVideoToDevice()
    {
        // arrange
        var facade = new CastingFacade(new DeviceExplorer());

        // act
        var action = async () => await facade.CastAsync(Guid.NewGuid(), Guid.NewGuid());

        // assert
        await action.Should().NotThrowAsync();
    }
}
