using GuitarChords.Lib.Notes;
using GuitarChords.Lib.Notes.Enum;
using GuitarChords.Lib.Scales;
using GuitarChords.Lib.Scales.Enum;

namespace GuitarChords.Lib.Extensions
{
    public static class EnumExtension
    {
        public static int GetValue(this NoteName noteName)
        {
            return (int) noteName;
        }

        public static int GetValue(this NoteAccidental noteAccidental)
        {
            return (int) noteAccidental;
        }

        public static Scale GetScale(this ScaleType type, Note note)
        {
            return note.GetScale(type);
        }
    }
}