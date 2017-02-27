using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteFifthDiminished : NoteRole
    {
        public NoteFifthDiminished(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteFifthDiminished(string note)
            : base(note)
        {
        }

        public NoteFifthDiminished(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteFifthDiminished;

        public override string RoleName => "Fifth Diminished";

        public override string RoleAbbreviation => "NO DATA";
    }
}