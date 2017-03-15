namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalAugmentedSeventh : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalAugmentedSeventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalAugmentedSeventh(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalAugmentedSeventh(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalAugmentedSeventh;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Seventh" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A7", "+7" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 7" };

        public override string QualityComposition { get; }
            = "Inusitée dans la pratique";

        public override int Semitones { get; }
            = 12;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalDiminishedSecond());
    }
}