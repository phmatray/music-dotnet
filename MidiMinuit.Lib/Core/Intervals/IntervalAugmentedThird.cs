namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalAugmentedThird : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalAugmentedThird(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalAugmentedThird(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalAugmentedThird(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalAugmentedThird;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Third" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A3", "+3" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 3" };

        public override string QualityComposition { get; }
            = "2 tons et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 5;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalDiminishedSixth());
    }
}