using Design.Patterns.Memento.Concretions;
using FluentAssertions;

namespace Design.Patterns.Memento;

public class MementoTests
{
    [Fact]
    public void Caretaker_ShouldStoreMemento_AndReturnMemento()
    {
        // arrange
        var caretaker = new Caretaker();
        var originator = new Originator();

        // act
        originator.SetState("hello");
        caretaker.AddMemento(originator.CreateMemento());
        originator.SetState("world");
        caretaker.AddMemento(originator.CreateMemento());

        var memento = caretaker.GetMemento(0);
        
        // assert
        memento.GetState().Should().Be("hello");
    }

    [Fact]
    public void Caretaker_ShouldStoreMemento_AndUseItToRestoreStateToOriginator()
    {
        // arrange
        var caretaker = new Caretaker();
        var originator = new Originator();

        // act
        originator.SetState("hello");
        caretaker.AddMemento(originator.CreateMemento());
        originator.SetState("world");
        caretaker.AddMemento(originator.CreateMemento());

        var memento = caretaker.GetMemento(0);
        
        // assert
        originator.GetState().Should().Be("world");
        
        // act
        originator.Restore(memento);
        
        // assert
        originator.GetState().Should().Be("hello");
    }
}
