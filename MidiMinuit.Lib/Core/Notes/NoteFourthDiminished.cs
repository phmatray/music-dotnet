namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteFourthDiminished : NoteQuality
    {
        public NoteFourthDiminished(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteFourthDiminished(string note)
            : base(note)
        {
        }

        public NoteFourthDiminished(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteFourthDiminished;

        public override string QualityName
            => "Fourth Diminished";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "1 ton et 2 demi-tons diatoniques";

        public override int Semitones
            => 4;
    }
}