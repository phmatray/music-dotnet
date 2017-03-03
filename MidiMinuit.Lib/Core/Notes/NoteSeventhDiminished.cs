namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSeventhDiminished : NoteQuality
    {
        public NoteSeventhDiminished(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
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

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteSeventhDiminished;

        public override string QualityName
            => "Seventh Diminished";

        public override string QualityAbbreviation
            => "7th dim";
    }
}