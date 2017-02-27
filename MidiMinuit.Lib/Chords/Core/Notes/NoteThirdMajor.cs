using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteThirdMajor : NoteRole
    {
        public NoteThirdMajor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirdMajor(string note)
            : base(note)
        {
        }

        public NoteThirdMajor(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteThirdMajor;

        public override string RoleName => "Third Major";

        public override string RoleAbbreviation => "NO DATA";
    }
}