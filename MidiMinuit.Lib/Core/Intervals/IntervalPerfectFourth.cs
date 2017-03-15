namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalPerfectFourth : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalPerfectFourth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalPerfectFourth(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalPerfectFourth(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalPerfectFourth;

        public override List<string> QualityName { get; }
            = new List<string> { "Perfect Fourth", "Diatessaron" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "P4" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Perf. 4" };

        public override string QualityComposition { get; }
            = "2 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 5;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalPerfectFifth());
    }
}