namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalDiminishedSecond : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalDiminishedSecond(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalDiminishedSecond(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalDiminishedSecond(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalDiminishedSecond;

        public override List<string> QualityName { get; }
            = new List<string> { "Diminished Second" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "d2", "°2" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "deg. 2", "dim. 2" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 0;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalAugmentedSeventh());
    }
}