namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;

    public class IntervalMajorThird : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalMajorThird(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalMajorThird(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalMajorThird(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalMajorThird;

        public override List<string> QualityName { get; }
            = new List<string> { "Major Third" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "M3" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Maj. 3" };

        public override string QualityComposition { get; }
            = "2 tons";

        public override int Semitones { get; }
            = 4;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalMinorSixth());
    }
}