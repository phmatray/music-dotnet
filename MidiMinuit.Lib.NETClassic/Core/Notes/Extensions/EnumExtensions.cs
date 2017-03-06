namespace MidiMinuit.Lib.Core.Notes
{
    public static class EnumExtensions
    {
        public static int GetValue(this NoteAccidentalEnum noteAccidental)
            => (int)noteAccidental;

        public static int GetValue(this NoteNameEnum noteName)
            => (int)noteName;

        public static int GetValue(this NoteQualityEnum noteQuality)
            => (int)noteQuality;
    }
}