using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteFifthAugmented : NoteRole
    {
        public NoteFifthAugmented(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteFifthAugmented(string note)
            : base(note)
        {
        }

        public NoteFifthAugmented(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteFifthAugmented;

        public override string RoleName => "Fifth Augmented";

        public override string RoleAbbreviation => "NO DATA";
    }
}