namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;

    public class IntervalDiminishedSixth : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalDiminishedSixth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalDiminishedSixth(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalDiminishedSixth(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalDiminishedSixth;

        public override List<string> QualityName { get; }
            = new List<string> { "Diminished Sixth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "d6", "°6" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "deg. 6", "dim. 6" };

        public override string QualityComposition { get; }
            = "2 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; }
            = 7;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalAugmentedThird());
    }
}