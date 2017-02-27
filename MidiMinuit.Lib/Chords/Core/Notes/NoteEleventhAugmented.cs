using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteEleventhAugmented : NoteRole
    {
        public NoteEleventhAugmented(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteEleventhAugmented(string note)
            : base(note)
        {
        }

        public NoteEleventhAugmented(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteEleventhAugmented;

        public override string RoleName => "Eleventh Augmented";

        public override string RoleAbbreviation => "NO DATA";
    }
}