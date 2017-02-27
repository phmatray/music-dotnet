using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteFourthPerfect : NoteRole
    {
        public NoteFourthPerfect(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteFourthPerfect(string note) : base(note)
        {
        }

        public NoteFourthPerfect(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteFourthPerfect;
        public override string RoleName => "Fourth Perfect";
        public override string RoleAbbreviation => "NO DATA";
    }
}