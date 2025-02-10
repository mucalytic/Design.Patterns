namespace Design.Patterns.Memento.Concretions;

public class Caretaker
{
    private readonly List<Originator.Memento> _mementos = [];
    
    public void AddMemento(Originator.Memento memento) =>
        _mementos.Add(memento);
    
    public Originator.Memento GetMemento(int index) =>
        _mementos[index];
}
