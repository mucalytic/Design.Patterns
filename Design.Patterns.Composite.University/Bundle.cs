using Xunit.Abstractions;

namespace Design.Patterns.Composite.University;

public class Bundle(ITestOutputHelper helper) : LearningResource
{
    private readonly HashSet<LearningResource> _learningResources = [];
    
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
        if (!_learningResources.Add(learningResource))
        {
            helper.WriteLine("Component already added");
        }
    }
    
    public override void Remove(LearningResource learningResource)
    {
        if (!_learningResources.Remove(learningResource))
        {
            helper.WriteLine("Component was not added");
        }
    }
    
    public override LearningResource GetLearningResource()
    {
        throw new NotImplementedException();
    }
}
