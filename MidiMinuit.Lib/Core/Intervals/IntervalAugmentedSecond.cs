namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalAugmentedSecond : NoteQuality
    {
        public IntervalAugmentedSecond(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedSecond(string note)
            : base(note)
        {
        }

        public IntervalAugmentedSecond(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedSecond;

        public override List<string> QualityName
            => new List<string> { "Augmented Second" };

        public override List<string> QualityAbbreviation
            => new List<string> { "A2", "+2" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Aug. 2" };

        public override string QualityComposition
            => "1 ton et 1 demi-ton chromatique";

        public override int Semitones
            => 3;
    }
}