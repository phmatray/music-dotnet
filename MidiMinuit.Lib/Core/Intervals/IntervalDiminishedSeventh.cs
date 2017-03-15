namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalDiminishedSeventh : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalDiminishedSeventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalDiminishedSeventh(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalDiminishedSeventh(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalDiminishedSeventh;

        public override List<string> QualityName { get; }
            = new List<string> { "Diminished Seventh" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "d7", "°7" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "deg. 7", "dim. 7" };

        public override string QualityComposition { get; }
            = "3 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; }
            = 9;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalAugmentedSecond());
    }
}