using GuitarChords.Lib.Enum;
using GuitarChords.Lib.Notes.Enum;

namespace GuitarChords.Lib.Notes
{
    public class NoteEleventhAugmented : NoteRole
    {
        public NoteEleventhAugmented(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteEleventhAugmented(string note) : base(note)
        {
        }

        public NoteEleventhAugmented(Note note) : base(note)
        {
        }

        public override Role Role => Role.NoteEleventhAugmented;
        public override string RoleName => "Eleventh Augmented";
        public override string RoleAbbreviation => "NO DATA";
    }
}