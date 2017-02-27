using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteFifthPerfect : NoteRole
    {
        public NoteFifthPerfect(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteFifthPerfect(string note) : base(note)
        {
        }

        public NoteFifthPerfect(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteFifthPerfect;
        public override string RoleName => "Fifth Perfect";
        public override string RoleAbbreviation => "NO DATA";
    }
}