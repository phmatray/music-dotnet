namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalDiminishedFourth : NoteQuality
    {
        public IntervalDiminishedFourth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalDiminishedFourth(string note)
            : base(note)
        {
        }

        public IntervalDiminishedFourth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedFourth;

        public override string QualityName
            => "Diminished Fourth";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "1 ton et 2 demi-tons diatoniques";

        public override int Semitones
            => 4;
    }
}