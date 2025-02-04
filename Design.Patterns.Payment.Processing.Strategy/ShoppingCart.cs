using Design.Patterns.Payment.Processing.Strategy.Interfaces;

namespace Design.Patterns.Payment.Processing.Strategy;

public class ShoppingCart
{
    private IPaymentStrategy? _paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy) =>
        _paymentStrategy = paymentStrategy;

    public void Checkout(decimal amount) =>
        _paymentStrategy?.Pay(amount);
}
