using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteSixthMinor : NoteRole
    {
        public NoteSixthMinor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteSixthMinor(string note) : base(note)
        {
        }

        public NoteSixthMinor(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteSixthMinor;
        public override string RoleName => "Sixth Minor";
        public override string RoleAbbreviation => "NO DATA";
    }
}