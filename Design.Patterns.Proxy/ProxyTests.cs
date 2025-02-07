using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Proxy;

public class ProxyTests
{
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void ProxyOperation_CallsRealSubjectOperation_WhenAllowedTo(bool allowed)
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var proxy = new Proxy(new RealSubject(helper, allowed));

        // act
        proxy.Operation();
        
        // assert
        helper.Received(allowed ? 1 : 0).WriteLine($"{nameof(RealSubject)}.{nameof(RealSubject.Operation)}");
    }
}
