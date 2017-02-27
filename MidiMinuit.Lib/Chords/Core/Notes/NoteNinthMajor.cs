using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteNinthMajor : NoteRole
    {
        public NoteNinthMajor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteNinthMajor(string note)
            : base(note)
        {
        }

        public NoteNinthMajor(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteNinthMajor;

        public override string RoleName => "Ninth Major";

        public override string RoleAbbreviation => "NO DATA";
    }
}