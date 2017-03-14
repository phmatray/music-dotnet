namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteFifthDiminished : NoteQuality
    {
        public NoteFifthDiminished(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
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

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteFifthDiminished;

        public override string QualityName
            => "Fifth Diminished";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "2 tons et 2 demi-tons diatoniques";

        public override int Semitones
            => 6;
    }
}