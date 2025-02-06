using Xunit.Abstractions;

namespace Design.Patterns.Composite.University.Components;

public class Bundle(ITestOutputHelper helper, string name) : LearningResource
{
    private readonly HashSet<LearningResource> _learningResources = [];

    private const decimal Discount = 20; 
    
    public override string GetName() => name;

    public override decimal GetPrice() =>
        _learningResources.Sum(lr => lr.GetPrice()) * ((100 - Discount) / 100);

    public override TimeSpan GetDuration() =>
        _learningResources.Aggregate(TimeSpan.Zero, (total, lr) => total.Add(lr.GetDuration()));
    
    public override void Add(LearningResource learningResource)
    {
        if (!_learningResources.Add(learningResource))
        {
            helper.WriteLine("Learning resource already added");
        }
    }
    
    public override void Remove(LearningResource learningResource)
    {
        if (!_learningResources.Remove(learningResource))
        {
            helper.WriteLine("Learning resource was not added");
        }
    }
    
    public override LearningResource? GetLearningResource(string childName)
    {
        try
        {
            return _learningResources.SingleOrDefault(lr => lr.GetName() == childName);
        }
        catch (InvalidOperationException)
        {
            helper.WriteLine("More than one learning resource with that name found");
        }
        catch (ArgumentNullException)
        {
            helper.WriteLine("Learning resource name must be specified");
        }
        return null;
    }
}
