namespace Design.Patterns.Composite.University.Components;

public class Course(string name, TimeSpan duration, decimal price) : LearningResource
{
    public override string GetName() => name;

    public override decimal GetPrice() => price;

    public override TimeSpan GetDuration() => duration;
}
