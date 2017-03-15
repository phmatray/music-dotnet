namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalAugmentedFifth : NoteQuality
    {
        public IntervalAugmentedFifth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedFifth(string note)
            : base(note)
        {
        }

        public IntervalAugmentedFifth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedFifth;

        public override List<string> QualityName
            => new List<string> { "Augmented Fifth" };

        public override List<string> QualityAbbreviation
            => new List<string> { "A5", "+5" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Aug. 5" };

        public override string QualityComposition
            => "3 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones
            => 8;
    }
}