using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteFourthAugmented : NoteRole
    {
        public NoteFourthAugmented(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteFourthAugmented(string note)
            : base(note)
        {
        }

        public NoteFourthAugmented(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteFourthAugmented;

        public override string RoleName => "Fourth Augmented";

        public override string RoleAbbreviation => "NO DATA";
    }
}