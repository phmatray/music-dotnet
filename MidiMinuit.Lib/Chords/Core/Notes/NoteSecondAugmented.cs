using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteSecondAugmented : NoteRole
    {
        public NoteSecondAugmented(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteSecondAugmented(string note)
            : base(note)
        {
        }

        public NoteSecondAugmented(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteSecondAugmented;

        public override string RoleName => "Second Augmented";

        public override string RoleAbbreviation => "NO DATA";
    }
}