namespace Design.Patterns.Payment.Processing.Strategy.Interfaces;

public interface IPaymentStrategy
{
    void Pay(decimal amount);
}
