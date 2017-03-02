namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSixthMinor : NoteQuality
    {
        public NoteSixthMinor(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSixthMinor(string note)
            : base(note)
        {
        }

        public NoteSixthMinor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteSixthMinor;

        public override string RoleName => "Sixth Minor";

        public override string RoleAbbreviation => "NO DATA";
    }
}