using System.Globalization;
using Design.Patterns.Payment.Processing.Strategy.Strategies;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Payment.Processing.Strategy;

public class StrategyTests
{
    [Fact]
    public void ShoppingCart_ShouldCallPayPalStrategy()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var paymentStrategy = new PayPalStrategy(helper);
        var shoppingCart = new ShoppingCart();
        const decimal amount = 200;
        
        // act
        shoppingCart.SetPaymentStrategy(paymentStrategy);
        shoppingCart.Checkout(amount);
        
        // assert
        helper.Received(1).WriteLine(amount.ToString(CultureInfo.InvariantCulture));
    }

    [Fact]
    public void ShoppingCart_ShouldCallCreditCardStrategy()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var paymentStrategy = new CreditCardStrategy(helper);
        var shoppingCart = new ShoppingCart();
        const decimal amount = 100;
        
        // act
        shoppingCart.SetPaymentStrategy(paymentStrategy);
        shoppingCart.Checkout(amount);
        
        // assert
        helper.Received(1).WriteLine(amount.ToString(CultureInfo.InvariantCulture));
    }

    [Fact]
    public void ShoppingCart_ShouldCallBankTransferStrategy()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var paymentStrategy = new BankTransferStrategy(helper);
        var shoppingCart = new ShoppingCart();
        const decimal amount = 50;
        
        // act
        shoppingCart.SetPaymentStrategy(paymentStrategy);
        shoppingCart.Checkout(amount);
        
        // assert
        helper.Received(1).WriteLine(amount.ToString(CultureInfo.InvariantCulture));
    }
}
