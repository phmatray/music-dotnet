namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;

    public class IntervalAugmentedSecond : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalAugmentedSecond(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalAugmentedSecond(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalAugmentedSecond(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalAugmentedSecond;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Second" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A2", "+2" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 2" };

        public override string QualityComposition { get; }
            = "1 ton et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 3;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalDiminishedSeventh());
    }
}