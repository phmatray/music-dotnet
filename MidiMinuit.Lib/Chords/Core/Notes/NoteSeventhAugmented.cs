using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteSeventhAugmented : NoteRole
    {
        public NoteSeventhAugmented(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteSeventhAugmented(string note)
            : base(note)
        {
        }

        public NoteSeventhAugmented(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteSeventhAugmented;

        public override string RoleName => "Seventh Augmented";

        public override string RoleAbbreviation => "NO DATA";
    }
}