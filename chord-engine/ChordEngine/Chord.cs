namespace ChordEngine;

public class Chord
{
    public Note Root { get; }
    public string Type { get; }
    public List<Note> Notes { get; }

    // Each chord tone is defined by (letter steps, half steps) from the root, e.g. the diminished
    // fifth of a diminished triad is 4 letter-steps and 6 half-steps above the root, which lets
    // TransposeDiatonic pick the theoretically correct enharmonic spelling (e.g. Ab, not G#).
    private static readonly Dictionary<string, List<(int LetterSteps, int Semitones)>> ChordTypes = new()
    {
        { "major", new List<(int, int)> { (0, 0), (2, 4), (4, 7) } },
        { "minor", new List<(int, int)> { (0, 0), (2, 3), (4, 7) } },
        { "diminished", new List<(int, int)> { (0, 0), (2, 3), (4, 6) } },
        { "augmented", new List<(int, int)> { (0, 0), (2, 4), (4, 8) } }
    };

    public Chord(Note root, string type)
    {
        Root = root;
        Type = type.ToLowerInvariant();
        Notes = GenerateChordNotes(Root, Type);
    }

    private static List<Note> GenerateChordNotes(Note root, string type)
    {
        if (!ChordTypes.ContainsKey(type))
        {
            throw new ArgumentException($"Unknown chord type: {type}");
        }

        var intervals = ChordTypes[type];
        var notes = intervals.Select(i => root.TransposeDiatonic(i.LetterSteps, i.Semitones)).ToList();

        return notes;
    }

    public override string ToString()
    {
        return string.Join('-', Notes.Select(n => n.Name));
    }
}