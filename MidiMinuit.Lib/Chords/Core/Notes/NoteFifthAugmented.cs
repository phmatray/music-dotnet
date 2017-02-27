using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteFifthAugmented : NoteRole
    {
        public NoteFifthAugmented(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteFifthAugmented(string note) : base(note)
        {
        }

        public NoteFifthAugmented(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteFifthAugmented;
        public override string RoleName => "Fifth Augmented";
        public override string RoleAbbreviation => "NO DATA";
    }
}