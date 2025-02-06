namespace Design.Patterns.Composite.University;

public abstract class LearningResource
{
    public abstract TimeSpan GetDuration();
    public abstract decimal GetPrice();
    public abstract void Add(LearningResource learningResource);
    public abstract void Remove(LearningResource learningResource);
    public abstract LearningResource GetLearningResource();
}
