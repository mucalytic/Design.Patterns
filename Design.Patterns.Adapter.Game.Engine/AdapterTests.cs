using Design.Patterns.Adapter.Game.Engine.Extensions;
using Design.Patterns.Adapter.Game.Engine.Adapters;
using Design.Patterns.Adapter.Game.Engine.Models;
using NSubstitute;

namespace Design.Patterns.Adapter.Game.Engine;

public class AdapterTests
{
    [Fact]
    public void InvokingAdaptor_ShouldInvokeAdaptee()
    {
        // arrange
        var legacy = Substitute.ForPartsOf<LegacyRectangle>(0, 0, 100, 50);;
        var adapter = new LegacyRectangleAdapter(legacy);

        // act
        adapter.Center();
        
        // assert
        legacy.Received(1).Shift(Arg.Any<int>(), Arg.Any<int>());
    }
}
