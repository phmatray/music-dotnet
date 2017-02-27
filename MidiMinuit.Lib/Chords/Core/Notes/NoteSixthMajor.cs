using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteSixthMajor : NoteRole
    {
        public NoteSixthMajor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteSixthMajor(string note)
            : base(note)
        {
        }

        public NoteSixthMajor(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteSixthMajor;

        public override string RoleName => "Sixth Major";

        public override string RoleAbbreviation => "NO DATA";
    }
}