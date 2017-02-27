using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteNinthMinor : NoteRole
    {
        public NoteNinthMinor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteNinthMinor(string note)
            : base(note)
        {
        }

        public NoteNinthMinor(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteNinthMinor;

        public override string RoleName => "Ninth Minor";

        public override string RoleAbbreviation => "NO DATA";
    }
}