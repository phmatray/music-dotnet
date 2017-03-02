namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteFourthPerfect : NoteQuality
    {
        public NoteFourthPerfect(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteFourthPerfect(string note)
            : base(note)
        {
        }

        public NoteFourthPerfect(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteFourthPerfect;

        public override string RoleName => "Fourth Perfect";

        public override string RoleAbbreviation => "NO DATA";
    }
}