namespace ChordEngine;

public record Interval
{
    // Default (major-scale) number of half steps for each simple diatonic interval number,
    // indexed 0..6 for interval numbers 1..7 (unison..seventh). An octave (number 8) is number 1
    // plus one compound octave - see CalculateAbbreviation.
    private static readonly int[] DefaultSemitonesBySimpleNumber = { 0, 2, 4, 5, 7, 9, 11 };

    public Note NoteA { get; }
    public Note NoteB { get; }
    public int HalfSteps { get; }
    public string Abbreviation { get; }
    public bool IsAscending { get; }

    public Interval(Note noteA, Note noteB)
    {
        NoteA = noteA;
        NoteB = noteB;
        HalfSteps = CalculateHalfSteps(noteA, noteB);
        Abbreviation = CalculateAbbreviation(noteA, noteB, HalfSteps);
        IsAscending = noteB.Pitch >= noteA.Pitch;
    }

    public Interval(Note noteA, int halfSteps)
    {
        NoteA = noteA;
        HalfSteps = halfSteps;
        NoteB = noteA.Transpose(halfSteps);
        Abbreviation = CalculateAbbreviation(noteA, NoteB, HalfSteps);
        IsAscending = true;
    }

    public override string ToString()
    {
        return $"{Abbreviation} ({NoteA.Name} to {NoteB.Name})";
    }

    private static int CalculateHalfSteps(Note noteA, Note noteB)
    {
        int halfSteps = noteB.Pitch - noteA.Pitch;
        return halfSteps;
    }

    /// <summary>
    /// Calculate the interval abbreviation (e.g. "M3", "P5", "A4") from the two notes' letter
    /// names - which determine the diatonic interval number (2nd, 3rd, 4th, ...) - together with
    /// the exact number of half steps between them, which determines the quality (perfect/major/
    /// minor/augmented/diminished).
    /// </summary>
    /// <remarks>
    /// A lookup keyed purely by half-step count (the previous implementation) cannot distinguish
    /// enharmonically-equivalent-but-theoretically-different intervals: 3 half steps is a minor
    /// 3rd when spelled C-Eb, but an augmented 2nd when spelled C-D#. It also drifted out of
    /// alignment with the semitone count entirely past 3 half steps, e.g. reporting a fourth
    /// (P4, 5 half steps) as a third (M3).
    /// </remarks>
    private static string CalculateAbbreviation(Note noteA, Note noteB, int halfSteps)
    {
        int absHalfSteps = Math.Abs(halfSteps);

        int letterA = noteA.LetterIndex + noteA.Octave * 7;
        int letterB = noteB.LetterIndex + noteB.Octave * 7;
        int letterDistance = Math.Abs(letterB - letterA);

        int diatonicNumber = letterDistance + 1;
        int simpleNumber = (diatonicNumber - 1) % 7 + 1;
        int compoundOctaves = (diatonicNumber - 1) / 7;

        int defaultSemitones = DefaultSemitonesBySimpleNumber[simpleNumber - 1] + compoundOctaves * 12;
        int offset = absHalfSteps - defaultSemitones;
        bool isPerfectType = simpleNumber is 1 or 4 or 5;

        string quality = (isPerfectType, offset) switch
        {
            (true, 0) => "P",
            (true, -1) => "D",
            (true, 1) => "A",
            (false, 0) => "M",
            (false, -1) => "m",
            (false, -2) => "D",
            (false, 1) => "A",
            _ => throw new InvalidOperationException(
                $"Cannot determine the interval quality for {absHalfSteps} half step(s) spanning a diatonic {diatonicNumber} (letters {letterDistance} apart).")
        };

        return $"{quality}{diatonicNumber}";
    }
}