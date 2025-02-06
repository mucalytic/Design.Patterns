using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Facade;

public class FacadeTests
{
    [Fact]
    public void Facade_CallsOperationsOnSubSystemClasses()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var facade = new Facade(helper);
        
        // act
        facade.Operation();
        
        // assert
        helper.Received(4).WriteLine(Arg.Any<string>());
    }
}
