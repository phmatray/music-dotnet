namespace ChordEngine;

public class PianoKey
{
    public Note Note { get; }
    public bool IsWhiteKey { get; }
    public bool IsBlackKey => !IsWhiteKey;

    public PianoKey(Note note)
    {
        Note = note;
        IsWhiteKey = CalculateIsWhiteKey(note);
    }

    private static bool CalculateIsWhiteKey(Note note)
    {
        string name = note.Name;

        return !(name.Contains('#') || name.Contains('b'));
    }
}