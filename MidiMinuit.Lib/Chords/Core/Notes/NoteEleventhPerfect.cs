using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Enum;

namespace MidiMinuit.Lib.Chords.Core.Notes
{
    public class NoteEleventhPerfect : NoteRole
    {
        public NoteEleventhPerfect(NoteName name = NoteName.C, NoteAccidental accidental = NoteAccidental.Natural)
            : base(name, accidental)
        {
        }

        public NoteEleventhPerfect(string note)
            : base(note)
        {
        }

        public NoteEleventhPerfect(Note note)
            : base(note)
        {
        }

        public override Role Role => Role.NoteEleventhPerfect;

        public override string RoleName => "Eleventh Perfect";

        public override string RoleAbbreviation => "NO DATA";
    }
}