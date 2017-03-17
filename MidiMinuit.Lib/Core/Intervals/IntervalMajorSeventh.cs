namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;

    public class IntervalMajorSeventh : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalMajorSeventh(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalMajorSeventh(Note note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalMajorSeventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalMajorSeventh;

        public override List<string> QualityName { get; }
            = new List<string> { "Major Seventh", "Supermajor Seventh" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "M7" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Maj. 7" };

        public override string QualityComposition { get; }
            = "5 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 11;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalMinorSecond());
    }
}