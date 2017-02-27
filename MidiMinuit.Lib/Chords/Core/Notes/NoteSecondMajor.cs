using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteSecondMajor : NoteRole
    {
        public NoteSecondMajor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteSecondMajor(string note) : base(note)
        {
        }

        public NoteSecondMajor(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteSecondMajor;
        public override string RoleName => "Second Major";
        public override string RoleAbbreviation => "NO DATA";
    }
}