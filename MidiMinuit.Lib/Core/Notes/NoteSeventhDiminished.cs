namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSeventhDiminished : NoteQuality
    {
        public NoteSeventhDiminished(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSeventhDiminished(string note)
            : base(note)
        {
        }

        public NoteSeventhDiminished(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteSeventhDiminished;

        public override string RoleName => "Seventh Diminished";

        public override string RoleAbbreviation => "7th dim";
    }
}