namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;

    public class IntervalDiminishedFifth : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalDiminishedFifth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalDiminishedFifth(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalDiminishedFifth(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalDiminishedFifth;

        public override List<string> QualityName { get; }
            = new List<string> { "Diminished Fifth", "Tritone" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "d5", "°5", "TT" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "deg. 5", "dim. 5" };

        public override string QualityComposition { get; }
            = "2 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 6;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalAugmentedFourth());
    }
}