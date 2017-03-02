namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSecondMinor : NoteQuality
    {
        public NoteSecondMinor(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSecondMinor(string note)
            : base(note)
        {
        }

        public NoteSecondMinor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteSecondMinor;

        public override string RoleName => "Second Minor";

        public override string RoleAbbreviation => "NO DATA";
    }
}