using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteSeventhAugmented : NoteRole
    {
        public NoteSeventhAugmented(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteSeventhAugmented(string note) : base(note)
        {
        }

        public NoteSeventhAugmented(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteSeventhAugmented;
        public override string RoleName => "Seventh Augmented";
        public override string RoleAbbreviation => "NO DATA";
    }
}