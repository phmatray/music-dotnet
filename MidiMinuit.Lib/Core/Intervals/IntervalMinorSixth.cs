namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;

    public class IntervalMinorSixth : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalMinorSixth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalMinorSixth(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalMinorSixth(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalMinorSixth;

        public override List<string> QualityName { get; }
            = new List<string> { "Minor Sixth", "Minor Hexachord", "Hexachordon Minus", "Lesser Hexachord" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "m6" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "min. 6" };

        public override string QualityComposition { get; }
            = "3 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 8;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalMajorThird());
    }
}