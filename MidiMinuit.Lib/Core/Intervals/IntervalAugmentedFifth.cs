namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;

    public class IntervalAugmentedFifth : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalAugmentedFifth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalAugmentedFifth(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalAugmentedFifth(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalAugmentedFifth;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Fifth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A5", "+5" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 5" };

        public override string QualityComposition { get; }
            = "3 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 8;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalDiminishedFourth());
    }
}