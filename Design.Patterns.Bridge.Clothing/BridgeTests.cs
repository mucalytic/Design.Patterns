using Design.Patterns.Bridge.Clothing.Adapters;
using Design.Patterns.Bridge.Clothing.Items;
using Design.Patterns.Bridge.Clothing.Views;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Bridge.Clothing;

public class BridgeTests
{
    [Fact]
    public void View_ShouldDisplayTextFormattedByAdapter()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var compact = new CompactClothingView(helper, new ShoesClothingAdapter(new Shoes()));

        // act
        compact.Display();
        
        // assert
        helper.Received(1).WriteLine("CompactClothingView");
        helper.Received(1).WriteLine("Title: Adidas Gravity");
    }
}
