using NSubstitute;
using Xunit.Abstractions;

namespace Design.Patterns.Adapter;

public class AdapterTests
{
    [Fact]
    public void InvokingAdaptor_ShouldInvokeAdaptee()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var target = new Adapter(new Adaptee(helper));

        // act
        target.Request();
        
        // assert
        helper.Received(1).WriteLine($"{nameof(Adaptee)}'s specific request invoked");
    }
}
