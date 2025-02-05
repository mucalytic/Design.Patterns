using Xunit.Abstractions;

namespace Design.Patterns.Adapter;

public class Adaptee(ITestOutputHelper helper)
{
    public void SpecificRequest() =>
        helper.WriteLine($"{nameof(Adaptee)}'s specific request invoked");
}
