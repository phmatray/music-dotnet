using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteFourthPerfect : NoteRole
    {
        public NoteFourthPerfect(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteFourthPerfect(string note)
            : base(note)
        {
        }

        public NoteFourthPerfect(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteFourthPerfect;

        public override string RoleName => "Fourth Perfect";

        public override string RoleAbbreviation => "NO DATA";
    }
}