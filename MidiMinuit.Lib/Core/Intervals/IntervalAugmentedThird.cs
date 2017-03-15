namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalAugmentedThird : NoteQuality
    {
        public IntervalAugmentedThird(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedThird(string note)
            : base(note)
        {
        }

        public IntervalAugmentedThird(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedThird;

        public override List<string> QualityName
            => new List<string> { "Augmented Third" };

        public override List<string> QualityAbbreviation
            => new List<string> { "A3", "+3" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Aug. 3" };

        public override string QualityComposition
            => "2 tons et 1 demi-ton chromatique";

        public override int Semitones
            => 5;
    }
}