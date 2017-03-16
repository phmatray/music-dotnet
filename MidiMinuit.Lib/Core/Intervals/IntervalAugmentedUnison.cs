namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalAugmentedUnison : IntervalQualitySimple
    {
        private IntervalQualitySimple _inverse;

        ////public IntervalAugmentedUnison(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalAugmentedUnison(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalAugmentedUnison(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Simple;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalAugmentedUnison;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Unison", "Chromatic Semitone", "Minor Semitone" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A1", "+1" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 1" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 1;

        public override IntervalQualitySimple Inverse
            => _inverse ?? (_inverse = new IntervalDiminishedOctave());
    }
}