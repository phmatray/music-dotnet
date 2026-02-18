namespace ChordEngine.UnitTests;

public class NoteTests
{
    [Theory]
    [InlineData(0, "C", -1)]
    [InlineData(12, "C", 0)]
    [InlineData(60, "C", 4)]
    [InlineData(69, "A", 4)]
    [InlineData(100, "E", 7)]
    [InlineData(127, "G", 9)]
    public void Note_Constructor_ShouldCreateNoteWithCorrectProperties(int pitch, string expectedName, int expectedOctave)
    {
        // Act
        var note = new Note (pitch);

        // Assert
        note.Pitch.Should().Be(pitch);
        note.Name.Should().Be(expectedName);
        // note.LetterIndex.Should().Be(expectedName.Substring(0, 1));
        note.Octave.Should().Be(expectedOctave);
    }
    
    [Theory]
    [InlineData("A", "A")]
    [InlineData("B", "B")]
    [InlineData("C", "C")]
    [InlineData("D", "D")]
    [InlineData("E", "E")]
    [InlineData("F", "F")]
    [InlineData("G", "G")]
    public void Note_ShouldHaveCorrectName(string input, string expected)
    {
        // Arrange
        var note = new Note(input);

        // Act
        var actual = note.Name;

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void Note_InvalidName_ShouldThrowException()
    {
        // Arrange
        string invalidNoteName = "H";

        // Act & Assert
        Assert.Throws<InvalidNoteNameException>(() => new Note(invalidNoteName));
    }

    [Fact]
    public void Note_ValidPitch_ShouldBeInRange()
    {
        // Arrange
        var note = new Note("A");

        // Act
        var actual = note.Pitch;

        // Assert
        actual.Should().BeInRange(0, 127);
    }

    [Theory]
    [InlineData("A#", "A#")]
    [InlineData("Bb", "Bb")]
    [InlineData("C#", "C#")]
    [InlineData("Db", "Db")]
    [InlineData("D#", "D#")]
    [InlineData("Eb", "Eb")]
    [InlineData("F#", "F#")]
    [InlineData("Gb", "Gb")]
    [InlineData("G#", "G#")]
    [InlineData("Ab", "Ab")]
    public void Note_ShouldHaveCorrectName_WithAccidentals(string input, string expected)
    {
        // Arrange
        var note = new Note(input);

        // Act
        var actual = note.Name;

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    public void Note_ValidPitchWithAccidentals_ShouldBeInRange()
    {
        // Arrange
        var note = new Note("A#");

        // Act
        var actual = note.Pitch;

        // Assert
        actual.Should().BeInRange(0, 127);
    }
    
    [Theory]
    [InlineData("C", 60)]
    [InlineData("D", 62)]
    [InlineData("E", 64)]
    [InlineData("F", 65)]
    [InlineData("G", 67)]
    [InlineData("A", 69)]
    [InlineData("B", 71)]
    public void Note_ShouldHaveCorrectPitch(string input, int expected)
    {
        // Arrange
        var note = new Note(input);

        // Act
        var actual = note.Pitch;

        // Assert
        actual.Should().Be(expected);
    }
    
    [Theory]
    [InlineData("C", 4, 1, "C#", 4, 61)]
    [InlineData("C#", 4, 1, "D", 4, 62)]
    [InlineData("D", 4, -1, "C#", 4, 61)]
    [InlineData("C", 4, 12, "C", 5, 72)]
    [InlineData("G#", 4, 3, "B", 4, 71)]
    [InlineData("F", 4, -6, "B", 3, 59)]
    [InlineData("C", 4, 24, "C", 6, 84)]
    public void Transpose_ShouldTransposeNoteByHalfSteps(
        string name, int octave, int halfSteps,
        string expectedName, int expectedOctave, int expectedPitch)
    {
        // Arrange
        var note = new Note(name, octave);

        // Act
        var transposedNote = note.Transpose(halfSteps);

        // Assert
        transposedNote.Name.Should().Be(expectedName);
        transposedNote.Octave.Should().Be(expectedOctave);
        transposedNote.Pitch.Should().Be(expectedPitch);
    }
}