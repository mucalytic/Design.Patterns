using Design.Patterns.Memento.Text.Box.Concretions;
using FluentAssertions;

namespace Design.Patterns.Memento.Text.Box;

public class MementoTests
{
    [Fact]
    public void TextHistory_ShouldStoreTextStates_AndUseThemToRestoreStateToTextBox_OnUndo()
    {
        // arrange
        var textBox = new TextBox();
        var textHistory = new TextHistory();

        // act
        textBox.SetText("hello");
        textHistory.Backup(textBox.Save());
        textBox.SetText("world");
        textHistory.Backup(textBox.Save());
        textHistory.Undo(textBox);

        // assert
        textBox.GetText().Should().Be("hello");
    }

    [Fact]
    public void TextHistory_ShouldStoreTextStates_AndUseThemToRestoreStateToTextBox_OnRedo()
    {
        // arrange
        var textBox = new TextBox();
        var textHistory = new TextHistory();

        // act
        textBox.SetText("hello");
        textHistory.Backup(textBox.Save());
        textBox.SetText("world");
        textHistory.Backup(textBox.Save());
        textHistory.Undo(textBox);
        textHistory.Redo(textBox);

        // assert
        textBox.GetText().Should().Be("world");
    }
}
