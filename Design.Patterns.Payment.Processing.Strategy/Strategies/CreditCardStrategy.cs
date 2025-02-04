using Design.Patterns.Payment.Processing.Strategy.Interfaces;
using System.Globalization;
using Xunit.Abstractions;

namespace Design.Patterns.Payment.Processing.Strategy.Strategies;

public class CreditCardStrategy(ITestOutputHelper helper) : IPaymentStrategy
{
    public void Pay(decimal amount) =>
        helper.WriteLine(amount.ToString(CultureInfo.InvariantCulture));
}
