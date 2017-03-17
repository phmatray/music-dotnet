namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;

    public class IntervalPerfectOctave : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalPerfectOctave(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalPerfectOctave(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalPerfectOctave(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalPerfectOctave;

        public override List<string> QualityName { get; }
            = new List<string> { "Perfect Octave" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "P8" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Perf. 8" };

        public override string QualityComposition { get; }
            = "5 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 12;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalPerfectUnison());
    }
}