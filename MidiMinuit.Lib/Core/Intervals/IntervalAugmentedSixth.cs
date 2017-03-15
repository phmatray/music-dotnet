namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalAugmentedSixth : NoteQuality
    {
        public IntervalAugmentedSixth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedSixth(string note)
            : base(note)
        {
        }

        public IntervalAugmentedSixth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedSixth;

        public override List<string> QualityName
            => new List<string> { "Augmented Sixth" };

        public override List<string> QualityAbbreviation
            => new List<string> { "A6", "+6" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Aug. 6" };

        public override string QualityComposition
            => "4 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones
            => 10;
    }
}