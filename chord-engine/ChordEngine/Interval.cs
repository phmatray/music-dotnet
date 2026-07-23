namespace ChordEngine;

public record Interval
{
    private static readonly string[] IntervalAbbreviations =
    {
        "P1", "m2", "M2", "A2", "m3", "M3", "D4", "P4", "A4", "D5", "P5", "A5", "m6", "M6", "m7", "M7", "P8"
    };

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
        Abbreviation = CalculateAbbreviation(HalfSteps);
        IsAscending = noteB.Pitch >= noteA.Pitch;
    }
    
    public Interval(Note noteA, int halfSteps)
    {
        NoteA = noteA;
        HalfSteps = halfSteps;
        NoteB = noteA.Transpose(halfSteps);
        Abbreviation = CalculateAbbreviation(HalfSteps);
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
    
    private static string CalculateAbbreviation(int halfSteps)
    {
        halfSteps = Math.Abs(halfSteps);
        if (halfSteps >= IntervalAbbreviations.Length)
        {
            throw new InvalidOperationException($"Cannot find the abbreviation for the interval with {halfSteps} half steps.");
        }

        return IntervalAbbreviations[halfSteps];
    }
}