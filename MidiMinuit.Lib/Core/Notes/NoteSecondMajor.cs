namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSecondMajor : NoteQuality
    {
        public NoteSecondMajor(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSecondMajor(string note)
            : base(note)
        {
        }

        public NoteSecondMajor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteSecondMajor;

        public override string RoleName => "Second Major";

        public override string RoleAbbreviation => "NO DATA";
    }
}