using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteThirdMinor : NoteRole
    {
        public NoteThirdMinor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirdMinor(string note) : base(note)
        {
        }

        public NoteThirdMinor(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteThirdMinor;
        public override string RoleName => "Third Minor";
        public override string RoleAbbreviation => "3rd min";
    }
}