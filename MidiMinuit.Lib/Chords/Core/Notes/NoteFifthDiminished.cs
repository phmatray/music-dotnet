using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteFifthDiminished : NoteRole
    {
        public NoteFifthDiminished(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteFifthDiminished(string note) : base(note)
        {
        }

        public NoteFifthDiminished(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteFifthDiminished;
        public override string RoleName => "Fifth Diminished";
        public override string RoleAbbreviation => "NO DATA";
    }
}