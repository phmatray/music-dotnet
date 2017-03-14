namespace MidiMinuit.Lib.Core.Notes
{
    public static class EnumExtensions
    {
        public static int GetValue(this NoteAccidentalEnum noteAccidental)
            => (int)noteAccidental;

        public static int GetValue(this NoteNameEnum noteName)
            => (int)noteName;

        public static int GetValue(this NoteNameLatinEnum noteName)
            => (int)noteName;

        public static NoteNameEnum ToNoteName(this NoteNameLatinEnum noteName)
            => (NoteNameEnum)(int)noteName;

        public static NoteNameLatinEnum ToNoteNameLatin(this NoteNameEnum noteName)
            => (NoteNameLatinEnum)(int)noteName;
    }
}