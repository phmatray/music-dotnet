namespace ChordEngine.UnitTests;

public class PianoKeyTests
{
    [Theory]
    [InlineData("A", true)]
    [InlineData("A#", false)]
    [InlineData("B", true)]
    [InlineData("C", true)]
    [InlineData("C#", false)]
    [InlineData("D", true)]
    [InlineData("D#", false)]
    [InlineData("E", true)]
    [InlineData("F", true)]
    [InlineData("F#", false)]
    [InlineData("G", true)]
    [InlineData("G#", false)]
    public void PianoKey_ShouldBeWhiteKey(string noteName, bool isWhiteKey)
    {
        // Arrange
        var note = new Note(noteName);
        var pianoKey = new PianoKey(note);

        // Act
        var actual = pianoKey.IsWhiteKey;

        // Assert
        actual.Should().Be(isWhiteKey);
    }
    
    [Theory]
    [InlineData("A#", true)]
    [InlineData("Bb", true)]
    [InlineData("C#", true)]
    [InlineData("Db", true)]
    [InlineData("D#", true)]
    [InlineData("Eb", true)]
    [InlineData("F#", true)]
    [InlineData("Gb", true)]
    [InlineData("G#", true)]
    [InlineData("Ab", true)]
    public void PianoKey_ShouldBeBlackKey(string noteName, bool isBlackKey)
    {
        // Arrange
        var note = new Note(noteName);
        var pianoKey = new PianoKey(note);

        // Act
        var actual = pianoKey.IsBlackKey;

        // Assert
        actual.Should().Be(isBlackKey);
    }
}