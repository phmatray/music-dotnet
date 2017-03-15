namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalAugmentedFourth : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalAugmentedFourth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalAugmentedFourth(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalAugmentedFourth(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalAugmentedFourth;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Fourth", "Tritone" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A4", "+4", "TT" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 4" };

        public override string QualityComposition { get; }
            = "2 tons, 1 demi-ton diatonique et 1 demi-ton chromatique ou 3 tons(Triton)";

        public override int Semitones { get; }
            = 6;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalDiminishedFifth());
    }
}