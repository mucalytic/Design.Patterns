using Design.Patterns.Flyweight.Text.Editor.Interfaces;
using System.Reactive;

namespace Design.Patterns.Flyweight.Text.Editor.Concretions;

public class Glyph(object intrinsicData) : IGlyph
{
    public Unit Operation(object extrinsicData) => Unit.Default;
}
