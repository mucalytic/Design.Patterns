namespace Design.Patterns.Iterator.Prime.Numbers.Interfaces;

public interface IPrimeIterator
{
    bool HasNext();
    int  Next();
    void Reset();
}
