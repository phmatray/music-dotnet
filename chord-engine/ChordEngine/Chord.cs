namespace ChordEngine;

public class Chord
{
    public Note Root { get; }
    public string Type { get; }
    public List<Note> Notes { get; }

    private static readonly Dictionary<string, List<int>> ChordTypes = new()
    {
        { "major", new List<int> { 0, 4, 7 } },
        { "minor", new List<int> { 0, 3, 7 } },
        { "diminished", new List<int> { 0, 3, 6 } },
        { "augmented", new List<int> { 0, 4, 8 } }
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
        var notes = intervals.Select(halfSteps => root.Transpose(halfSteps)).ToList();

        return notes;
    }

    public override string ToString()
    {
        return string.Join('-', Notes.Select(n => n.Name));
    }
}