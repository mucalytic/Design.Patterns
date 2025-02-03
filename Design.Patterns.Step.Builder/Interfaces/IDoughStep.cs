using Design.Patterns.Step.Builder.Models;

namespace Design.Patterns.Step.Builder.Interfaces;

public interface IDoughStep
{
    ISauceStep WithDough(Action<Dough.Builder> buildDoughAction);
}
