namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalAugmentedSixth : NoteQuality
    {
        public IntervalAugmentedSixth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedSixth(string note)
            : base(note)
        {
        }

        public IntervalAugmentedSixth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedSixth;

        public override string QualityName
            => "Augmented Sixth";

        public override string QualityAbbreviation
            => "A6";

        public override string QualityAbbreviation2
            => "NO DATA";

        public override string QualityComposition
            => "4 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones
            => 10;
    }
}