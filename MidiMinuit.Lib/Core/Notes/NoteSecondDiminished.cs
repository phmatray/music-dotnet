namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSecondDiminished : NoteQuality
    {
        public NoteSecondDiminished(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSecondDiminished(string note)
            : base(note)
        {
        }

        public NoteSecondDiminished(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteSecondDiminished;

        public override string QualityName
            => "Second Diminished";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones
            => 0;
    }
}