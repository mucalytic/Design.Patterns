using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Template.Method;

public class TemplateMethodTests
{
    [Fact]
    public void TemplateMethods_CallAllOperations()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var template1 = new ConcreteClass1(helper);
        var template2 = new ConcreteClass2(helper);

        // act
        template1.TemplateMethod();
        template2.TemplateMethod();
        
        // assert
        helper.Received(1).WriteLine("ConcreteClass1:PrimitiveOperation1 called");
        helper.Received(1).WriteLine("ConcreteClass1:PrimitiveOperation2 called");
        helper.Received(1).WriteLine("AbstractClass:Hook called");
        helper.Received(1).WriteLine("ConcreteClass2:PrimitiveOperation1 called");
        helper.Received(1).WriteLine("ConcreteClass2:PrimitiveOperation2 called");
        helper.Received(1).WriteLine("ConcreteClass2:Hook called");
    }
}
