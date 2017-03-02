namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteThirteenthMajor : NoteQuality
    {
        public NoteThirteenthMajor(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirteenthMajor(string note)
            : base(note)
        {
        }

        public NoteThirteenthMajor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteThirteenthMajor;

        public override string RoleName => "Thirteenth Major";

        public override string RoleAbbreviation => "NO DATA";
    }
}