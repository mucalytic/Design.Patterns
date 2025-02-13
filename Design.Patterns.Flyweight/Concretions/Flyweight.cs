using Design.Patterns.Flyweight.Interfaces;
using Design.Patterns.Flyweight.Models;
using Xunit.Abstractions;

namespace Design.Patterns.Flyweight.Concretions;

public class Flyweight(ITestOutputHelper helper, IntrinsicState intrinsicState) : IFlyweight
{
    public void Operation(ExtrinsicState extrinsicState) =>
        helper.WriteLine(string.Join(' ',
            $"{nameof(Flyweight)} with intrinsic state {intrinsicState.Value}",
            $"did operation with extrinsic state {extrinsicState.Value}"));
}
