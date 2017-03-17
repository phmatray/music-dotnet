namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;

    public class IntervalMajorSecond : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalMajorSecond(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalMajorSecond(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalMajorSecond(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalMajorSecond;

        public override List<string> QualityName { get; }
            = new List<string> { "Major Second", "Tone", "Whole Tone", "Whole Step" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "M2" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Maj. 2" };

        public override string QualityComposition { get; }
            = "1 ton";

        public override int Semitones { get; }
            = 2;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalMinorSeventh());
    }
}