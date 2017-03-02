namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteThirdMajor : NoteQuality
    {
        public NoteThirdMajor(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirdMajor(string note)
            : base(note)
        {
        }

        public NoteThirdMajor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteThirdMajor;

        public override string RoleName => "Third Major";

        public override string RoleAbbreviation => "NO DATA";
    }
}