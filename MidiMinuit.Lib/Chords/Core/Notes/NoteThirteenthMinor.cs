using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteThirteenthMinor : NoteRole
    {
        public NoteThirteenthMinor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirteenthMinor(string note) : base(note)
        {
        }

        public NoteThirteenthMinor(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteThirteenthMinor;
        public override string RoleName => "Thirteenth Minor";
        public override string RoleAbbreviation => "NO DATA";
    }
}