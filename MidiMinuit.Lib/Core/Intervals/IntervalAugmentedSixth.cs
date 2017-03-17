namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;

    public class IntervalAugmentedSixth : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalAugmentedSixth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalAugmentedSixth(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalAugmentedSixth(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalAugmentedSixth;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Sixth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A6", "+6" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 6" };

        public override string QualityComposition { get; }
            = "4 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 10;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalDiminishedThird());
    }
}