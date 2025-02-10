namespace Design.Patterns.Memento.Text.Box.Concretions;

public class TextHistory
{
    private readonly Stack<TextBox.TextState> _undoStack = [];
    private readonly Stack<TextBox.TextState> _redoStack = [];

    public void Backup(TextBox.TextState textState) =>
        _undoStack.Push(textState);

    public void Undo(TextBox textBox)
    {
        if (_undoStack.TryPop(out var lastTextState))
        {
            _redoStack.Push(lastTextState);
        }
        if (_undoStack.TryPeek(out var nextTextState))
        {
            textBox.Restore(nextTextState);
        }
    }

    public void Redo(TextBox textBox)
    {
        if (!_redoStack.TryPop(out var textState)) return;
        _undoStack.Push(textState);
        textBox.Restore(textState);
    }
}
