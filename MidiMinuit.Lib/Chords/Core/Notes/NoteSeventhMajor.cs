using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteSeventhMajor : NoteRole
    {
        public NoteSeventhMajor(string note)
            : base(note)
        {
        }

        public NoteSeventhMajor(Note note)
            : base(note)
        {
        }

        public NoteSeventhMajor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public override Role Role => Role.NoteSeventhMajor;

        public override string RoleName => "Seventh Major";

        public override string RoleAbbreviation => "NO DATA";
    }
}