using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteSeventhMajor : NoteRole
    {
        public NoteSeventhMajor(string note) : base(note)
        {
        }

        public NoteSeventhMajor(Note note) : base(note)
        {
        }

        public NoteSeventhMajor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public override Role Role => Role.NoteSeventhMajor;
        public override string RoleName => "Seventh Major";
        public override string RoleAbbreviation => "NO DATA";
    }
}