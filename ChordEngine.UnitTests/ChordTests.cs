namespace ChordEngine.UnitTests;

public class ChordTests
{
    [Theory]
    [InlineData("C", "major", "C-E-G")]
    [InlineData("A", "minor", "A-C-E")]
    [InlineData("D", "diminished", "D-F-Ab")]
    [InlineData("G", "augmented", "G-B-D#")]
    public void Chord_ShouldGenerateChordFromRootAndType(string root, string type, string expectedNotes)
    {
        // Arrange
        var rootNote = new Note(root);

        // Act
        var chord = new Chord(rootNote, type);
        var actualNotes = chord.ToString();

        // Assert
        actualNotes.Should().Be(expectedNotes);
    }
}