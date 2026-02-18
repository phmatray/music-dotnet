namespace ChordEngine;

public record Note
{
    public static readonly IReadOnlyDictionary<string, int> NoteToPitch = new Dictionary<string, int>
    {
        { "C", 0 },
        { "C#", 1 }, { "Db", 1 },
        { "D", 2 },
        { "D#", 3 }, { "Eb", 3 },
        { "E", 4 },
        { "F", 5 },
        { "F#", 6 }, { "Gb", 6 },
        { "G", 7 },
        { "G#", 8 }, { "Ab", 8 },
        { "A", 9 },
        { "A#", 10 }, { "Bb", 10 },
        { "B", 11 }
    };

    private static readonly IReadOnlyDictionary<int, string> PitchToNote = NoteToPitch
        .GroupBy(kvp => kvp.Value)
        .ToDictionary(g => g.Key, g => g.First().Key);

    private const int DefaultOctave = 4;

    public string Name { get; }
    public int LetterIndex { get; }
    public int Pitch { get; }
    public int Octave { get; }

    /// <summary>
    /// Initialize a new Note with the given name and octave.
    /// </summary>
    public Note(string name, int octave = DefaultOctave)
    {
        if (!IsValidNoteName(name))
        {
            throw new InvalidNoteNameException($"Invalid note name '{name}'.");
        }
        
        Name = name;
        LetterIndex = CalculateLetterIndex(Name);
        Pitch = CalculatePitch(Name, octave);
        Octave = octave;
    }

    /// <summary>
    /// Initialize a new Note with the given pitch.
    /// </summary>
    public Note(int pitch)
    {
        if (pitch is < 0 or > 127)
        {
            throw new ArgumentException($"Invalid pitch value {pitch}. Must be between 0 and 127.");
        }

        Pitch = pitch;
        Name = FindNoteNameByPitch(pitch);
        LetterIndex = CalculateLetterIndex(Name);
        Octave = pitch / 12 - 1;
    }
    
    /// <summary>
    /// Transpose the note by a number of half steps.
    /// </summary>
    public Note Transpose(int halfSteps)
    {
        int newPitch = (Pitch + halfSteps) % 12;
        if (newPitch < 0)
        {
            newPitch += 12;
        }

        int totalPitch = Pitch + halfSteps;
        int newOctave = totalPitch / 12 - 1;
        if (totalPitch < 0 && totalPitch % 12 != 0) // Decrement the octave if the total pitch is negative and not a multiple of 12
        {
            newOctave--;
        }

        if (newOctave < -1 || newOctave > 9)
        {
            throw new InvalidOctaveException($"Invalid octave value {newOctave}. Must be between -1 and 9.");
        }

        string newName = FindNoteNameByPitch(newPitch);
        return new Note(newName, newOctave);
    }

    private static bool IsValidNoteName(string name)
    {
        return NoteToPitch.ContainsKey(name);
    }
    
    /// <summary>
    /// Calculate the letter index for the note.
    /// </summary>
    private static int CalculateLetterIndex(string name)
    {
        int index = "CDEFGAB".IndexOf(name[0]);
        if (index < 0)
        {
            throw new InvalidNoteNameException($"Invalid note name '{name}'. The first character should be a letter from A to G.");
        }
        return index;
    }
    
    /// <summary>
    /// Calculate the pitch for the note.
    /// </summary>
    private static int CalculatePitch(string name, int octave)
    {
        int pitch = NoteToPitch[name] + (octave + 1) * 12;
        return pitch;
    }
    
    /// <summary>
    /// Find the note name by the pitch.
    /// </summary>
    private static string FindNoteNameByPitch(int pitch)
    {
        int relativePitch = pitch % 12;
        if (PitchToNote.TryGetValue(relativePitch, out string? noteName))
        {
            return noteName;
        }

        throw new ArgumentException($"No note name found for pitch: {pitch}");
    }
}

public class InvalidNoteNameException : Exception
{
    public InvalidNoteNameException(string message) : base(message) { }
}

public class InvalidOctaveException : Exception
{
    public InvalidOctaveException(string message) : base(message) { }
}
