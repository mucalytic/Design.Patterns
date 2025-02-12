namespace Design.Patterns.Chain.Of.Responsibility.Spam.Detector.Abstractions;

public abstract class Handler
{
    protected Handler? Successor { get; private set; }

    public void SetSuccessor(Handler successor) =>
        Successor = successor;
    
    public abstract void Handle(string request);
}
