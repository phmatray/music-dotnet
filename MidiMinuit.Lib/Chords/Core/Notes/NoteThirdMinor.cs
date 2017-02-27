using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteThirdMinor : NoteRole
    {
        public NoteThirdMinor(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirdMinor(string note)
            : base(note)
        {
        }

        public NoteThirdMinor(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteThirdMinor;

        public override string RoleName => "Third Minor";

        public override string RoleAbbreviation => "3rd min";
    }
}