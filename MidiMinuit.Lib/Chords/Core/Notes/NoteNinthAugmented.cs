using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteNinthAugmented : NoteRole
    {
        public NoteNinthAugmented(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteNinthAugmented(string note) : base(note)
        {
        }

        public NoteNinthAugmented(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteNinthAugmented;
        public override string RoleName => "Ninth Augmented";
        public override string RoleAbbreviation => "NO DATA";
    }
}