namespace Design.Patterns.Step.Builder.Interfaces;

public interface ICheeseStep
{
    IToppingStep WithCheese(string cheese);
}
