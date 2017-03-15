namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalMinorSeventh : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalMinorSeventh(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalMinorSeventh(Note note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalMinorSeventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalMinorSeventh;

        public override List<string> QualityName { get; }
            = new List<string> { "Minor Seventh" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "m7" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "min. 7" };

        public override string QualityComposition { get; }
            = "4 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 10;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalMajorSecond());
    }
}