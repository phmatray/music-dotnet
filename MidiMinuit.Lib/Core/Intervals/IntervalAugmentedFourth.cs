namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalAugmentedFourth : NoteQuality
    {
        public IntervalAugmentedFourth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedFourth(string note)
            : base(note)
        {
        }

        public IntervalAugmentedFourth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedFourth;

        public override string QualityName
            => "Augmented Fourth";

        public override string QualityAbbreviation
            => "A4";

        public override string QualityAbbreviation2
            => "NO DATA";

        public override string QualityComposition
            => "2 tons, 1 demi-ton diatonique et 1 demi-ton chromatique ou 3 tons(Triton)";

        public override int Semitones
            => 6;
    }
}