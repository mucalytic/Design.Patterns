using Design.Patterns.Simple.Factory.Factories;
using Design.Patterns.Simple.Factory.Passwords;
using FluentAssertions;

namespace Design.Patterns.Simple.Factory;

public class SimpleFactoryTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    public void PasswordFactory_GeneratesSimplePassword_WhenLengthLessThanFive(ushort length)
    {
        // act
        var password = PasswordFactory.Generate(length);

        // assert
        password.Should().BeOfType<SimplePassword>();
    }
    
    [Theory]
    [InlineData(5)]
    [InlineData(6)]
    [InlineData(7)]
    [InlineData(8)]
    [InlineData(9)]
    [InlineData(10)]
    public void PasswordFactory_GeneratesComplexPassword_WhenLengthGreaterOrEqualToThanFive(ushort length)
    {
        // act
        var password = PasswordFactory.Generate(length);

        // assert
        password.Should().BeOfType<ComplexPassword>();
    }
}
