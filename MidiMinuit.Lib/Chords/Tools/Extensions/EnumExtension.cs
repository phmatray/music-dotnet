using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Core.Scales.Base;
using MidiMinuit.Lib.Chords.Core.Scales.Enum;

namespace MidiMinuit.Lib.Chords.Tools.Extensions
{
    public static class EnumExtension
    {
        public static int GetValue(this NoteName noteName)
        {
            return (int)noteName;
        }

        public static int GetValue(this NoteAccidental noteAccidental)
        {
            return (int)noteAccidental;
        }

        public static Scale GetScale(this ScaleType type, Note note)
        {
            return note.GetScale(type);
        }
    }
}