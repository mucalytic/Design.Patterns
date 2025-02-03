using Design.Patterns.Step.Builder.Models;

namespace Design.Patterns.Step.Builder.Interfaces;

public interface IToppingStep
{
    IToppingStep WithTopping(string topping);
    Pizza Build();
}
