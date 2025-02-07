using Microsoft.Reactive.Testing;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Proxy.Hi.Res.Image;

public class ProxyTests
{
    private readonly ITestOutputHelper _helper = Substitute.For<ITestOutputHelper>();
    private readonly TestScheduler _scheduler = new();
    
    [Fact]
    public void Proxies_DisplayLowResImage_WhenTwoSecondsIsWaited()
    {
        // arrange
        using var image1Proxy = new ImageProxy(_helper, _scheduler, "filename1");
        using var image2Proxy = new ImageProxy(_helper, _scheduler, "filename2");

        // act
        image1Proxy.Display();
        image2Proxy.Display();
        _scheduler.AdvanceBy(TimeSpan.FromSeconds(2).Ticks);
        image1Proxy.Display();
        image2Proxy.Display();
        
        // assert
        _helper.Received(2).WriteLine("Displaying low-res-filename1");
        _helper.Received(2).WriteLine("Displaying low-res-filename2");
    }

    [Fact]
    public void Proxies_DisplayImage_WhenFourSecondsIsWaited()
    {
        // arrange
        using var image1Proxy = new ImageProxy(_helper, _scheduler, "filename1");
        using var image2Proxy = new ImageProxy(_helper, _scheduler, "filename2");

        // act
        image1Proxy.Display();
        image2Proxy.Display();
        _scheduler.AdvanceBy(TimeSpan.FromSeconds(2).Ticks);
        image1Proxy.Display();
        image2Proxy.Display();
        _scheduler.AdvanceBy(TimeSpan.FromSeconds(2).Ticks);
        image1Proxy.Display();
        image2Proxy.Display();
        
        // assert
        _helper.Received(2).WriteLine("Displaying low-res-filename1");
        _helper.Received(2).WriteLine("Displaying low-res-filename2");
        _helper.Received(1).WriteLine("Displaying filename1");
        _helper.Received(1).WriteLine("Displaying filename2");
    }
}
