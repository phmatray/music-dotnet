namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteFifthPerfect : NoteQuality
    {
        public NoteFifthPerfect(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteFifthPerfect(string note)
            : base(note)
        {
        }

        public NoteFifthPerfect(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteFifthPerfect;

        public override string RoleName => "Fifth Perfect";

        public override string RoleAbbreviation => "NO DATA";
    }
}