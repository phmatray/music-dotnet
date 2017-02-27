using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes.Base
{
    public abstract class NoteRole : Note, INoteRole
    {
        protected NoteRole(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        protected NoteRole(string note)
            : base(note)
        {
        }

        protected NoteRole(Note note)
            : base(note)
        {
        }

        public abstract Role Role { get; }

        public abstract string RoleName { get; }

        public abstract string RoleAbbreviation { get; }
    }
}