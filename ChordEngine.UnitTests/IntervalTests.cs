namespace ChordEngine.UnitTests;

public class IntervalTests
{
    [Theory]
    [InlineData("C", "C", 0, "P1")]
    [InlineData("C", "D", 2, "M2")]
    [InlineData("C", "E", 4, "m3")]
    [InlineData("C", "F", 5, "P4")]
    [InlineData("C", "G", 7, "P5")]
    [InlineData("C", "A", 9, "M6")]
    [InlineData("C", "B", 11, "M7")]
    public void Interval_ShouldCalculateNumberOfHalfSteps(string note1, string note2, int halfSteps, string name)
    {
        // Arrange
        var noteA = new Note(note1);
        var noteB = new Note(note2);

        // Act
        var interval = new Interval(noteA, noteB);
        var actual = interval.HalfSteps;

        // Assert
        actual.ShouldBe(halfSteps);
        interval.Abbreviation.ShouldBe(name);
    }

    [Theory]
    [InlineData("C", 0, "C", "P1 (C to C)")]
    [InlineData("C", 1, "Db", "m2 (C to Db)")]
    [InlineData("C", 2, "D", "M2 (C to D)")]
    [InlineData("C", 3, "D#", "A2 (C to D#)")]
    [InlineData("C", 3, "Eb", "m3 (C to Eb)")]
    [InlineData("C", 4, "E", "M3 (C to E)")]
    [InlineData("C", 4, "Fb", "D4 (C to Fb)")]
    [InlineData("C", 5, "F", "P4 (C to F)")]
    [InlineData("C", 6, "F#", "A4 (C to F#)")]
    [InlineData("C", 6, "Gb", "D5 (C to Gb)")]
    [InlineData("C", 7, "G", "P5 (C to G)")]
    [InlineData("C", 8, "G#", "A5 (C to G#)")]
    [InlineData("C", 8, "Ab", "m6 (C to Ab)")]
    [InlineData("C", 9, "A", "M6 (C to A)")]
    [InlineData("C", 10, "Bb", "m7 (C to Bb)")]
    [InlineData("C", 11, "B", "M7 (C to B)")]
    [InlineData("C", 12, "C", "P8 (C to C)")]
    public void Interval_ShouldCalculateIntervalFromHalfSteps(string note1, int halfSteps, string note2, string name)
    {
        // Arrange
        var noteA = new Note(note1);

        // Act
        var interval = new Interval(noteA, halfSteps);
        var actual = interval.NoteB;

        // Assert
        actual.Name.ShouldBe(note2);
        interval.ToString().ShouldBe(name);
    }
    

}