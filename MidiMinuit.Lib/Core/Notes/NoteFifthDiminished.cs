namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteFifthDiminished : NoteQuality
    {
        public NoteFifthDiminished(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteFifthDiminished(string note)
            : base(note)
        {
        }

        public NoteFifthDiminished(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteFifthDiminished;

        public override string RoleName => "Fifth Diminished";

        public override string RoleAbbreviation => "NO DATA";
    }
}