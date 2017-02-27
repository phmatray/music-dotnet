using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteSecondMinor : NoteRole
    {
        public NoteSecondMinor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteSecondMinor(string note) : base(note)
        {
        }

        public NoteSecondMinor(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteSecondMinor;
        public override string RoleName => "Second Minor";
        public override string RoleAbbreviation => "NO DATA";
    }
}