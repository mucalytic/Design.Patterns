using System.Reactive;

namespace Design.Patterns.Flyweight.Text.Editor.Interfaces;

public interface IGlyph
{
    Unit Operation(object extrinsicData);
}
