namespace Design.Patterns.Step.Builder.Interfaces;

public interface ISauceStep
{
    ICheeseStep WithSauce(string cheese);
}
