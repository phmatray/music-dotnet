namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalDiminishedFourth : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalDiminishedFourth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalDiminishedFourth(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalDiminishedFourth(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalDiminishedFourth;

        public override List<string> QualityName { get; }
            = new List<string> { "Diminished Fourth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "d4", "°4" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "deg. 4", "dim. 4" };

        public override string QualityComposition { get; }
            = "1 ton et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 4;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalAugmentedFifth());
    }
}