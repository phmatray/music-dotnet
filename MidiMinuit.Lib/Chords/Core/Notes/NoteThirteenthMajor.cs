using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteThirteenthMajor : NoteRole
    {
        public NoteThirteenthMajor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirteenthMajor(string note) : base(note)
        {
        }

        public NoteThirteenthMajor(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteThirteenthMajor;
        public override string RoleName => "Thirteenth Major";
        public override string RoleAbbreviation => "NO DATA";
    }
}