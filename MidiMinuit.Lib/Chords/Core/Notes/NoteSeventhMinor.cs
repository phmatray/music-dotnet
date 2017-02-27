using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteSeventhMinor : NoteRole
    {
        public NoteSeventhMinor(string note)
            : base(note)
        {
        }

        public NoteSeventhMinor(Note note)
            : base(note)
        {
        }

        public NoteSeventhMinor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public override Role Role => Role.NoteSeventhMinor;

        public override string RoleName => "Seventh Minor";

        public override string RoleAbbreviation => "NO DATA";
    }
}