namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalAugmentedFourth : NoteQuality
    {
        public IntervalAugmentedFourth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedFourth(string note)
            : base(note)
        {
        }

        public IntervalAugmentedFourth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedFourth;

        public override List<string> QualityName
            => new List<string> { "Augmented Fourth", "Tritone" };

        public override List<string> QualityAbbreviation
            => new List<string> { "A4", "+4" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Aug. 4" };

        public override string QualityComposition
            => "2 tons, 1 demi-ton diatonique et 1 demi-ton chromatique ou 3 tons(Triton)";

        public override int Semitones
            => 6;
    }
}