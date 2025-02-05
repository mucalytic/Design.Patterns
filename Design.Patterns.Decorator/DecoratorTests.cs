using Design.Patterns.Decorator.Components;
using Design.Patterns.Decorator.Decorators;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Decorator;

public class DecoratorTests
{
    [Fact]
    public void ConcreteComponentWritesItsName_WhenOperationIsCalled()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var component = new ConcreteComponent(helper);

        // act
        component.Operation();
        
        // assert
        helper.Received(1).WriteLine(nameof(ConcreteComponent));
    }

    [Fact]
    public void ConcreteDecorator1WritesItsName_AndNameOfConcreteComponent_WhenOperationIsCalled()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var component = new ConcreteDecorator1(helper, new ConcreteComponent(helper));

        // act
        component.Operation();
        
        // assert
        helper.Received(1).WriteLine(nameof(ConcreteComponent));
        helper.Received(2).WriteLine($"-------- {nameof(ConcreteDecorator1)} --------");
    }
    
    [Fact]
    public void ConcreteDecorator2WritesItsName_AndNamesOfWrappedComponents_WhenOperationIsCalled()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var component = new ConcreteDecorator2(helper, new ConcreteDecorator1(helper, new ConcreteComponent(helper)));

        // act
        component.Operation();
        
        // assert
        helper.Received(1).WriteLine(nameof(ConcreteComponent));
        helper.Received(2).WriteLine($"-------- {nameof(ConcreteDecorator1)} --------");
        helper.Received(2).WriteLine($"-------- {nameof(ConcreteDecorator2)} --------");
    }
}
