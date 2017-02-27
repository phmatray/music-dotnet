using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteSeventhMinor : NoteRole
    {
        public NoteSeventhMinor(string note) : base(note)
        {
        }

        public NoteSeventhMinor(Note note) : base(note)
        {
        }

        public NoteSeventhMinor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public override Role Role => Role.NoteSeventhMinor;
        public override string RoleName => "Seventh Minor";
        public override string RoleAbbreviation => "NO DATA";
    }
}