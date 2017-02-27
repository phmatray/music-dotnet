using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteSeventhDiminished : NoteRole
    {
        public NoteSeventhDiminished(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteSeventhDiminished(string note) : base(note)
        {
        }

        public NoteSeventhDiminished(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteSeventhDiminished;
        public override string RoleName => "Seventh Diminished";
        public override string RoleAbbreviation => "7th dim";
    }
}