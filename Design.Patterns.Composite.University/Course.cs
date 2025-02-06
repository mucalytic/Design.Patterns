using Xunit.Abstractions;

namespace Design.Patterns.Composite.University;

public class Course(ITestOutputHelper helper) : LearningResource
{
    public override TimeSpan GetDuration()
    {
        throw new NotImplementedException();
    }

    public override decimal GetPrice()
    {
        throw new NotImplementedException();
    }

    public override void Add(LearningResource learningResource)
    {
        throw new NotImplementedException();
    }

    public override void Remove(LearningResource learningResource)
    {
        throw new NotImplementedException();
    }

    public override LearningResource GetLearningResource()
    {
        throw new NotImplementedException();
    }
}
