using Design.Patterns.Bridge.Implementors;
using Design.Patterns.Bridge.Concretions;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Bridge;

public class BridgeTests
{
    [Fact]
    public void Concretions_ShouldBeProvidedImplementations_ByImplementors()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var concretion1 = new Concretion1(new Implementor1(helper));
        var concretion2 = new Concretion1(new Implementor2(helper));

        // act
        concretion1.Foo();
        concretion2.Foo();
        
        // assert
        helper.Received(1).WriteLine($"Hello from {nameof(Implementor1)}");
        helper.Received(1).WriteLine($"Hello from {nameof(Implementor2)}");
    }
}
