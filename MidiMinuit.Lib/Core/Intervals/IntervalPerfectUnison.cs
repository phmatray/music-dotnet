namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalPerfectUnison : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalPerfectUnison(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalPerfectUnison(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalPerfectUnison(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalPerfectUnison;

        public override List<string> QualityName { get; }
            = new List<string> { "Perfect Unison", "Prime", "Perfect Prime" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "P1" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Perf. 1" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 0;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalPerfectOctave());
    }
}