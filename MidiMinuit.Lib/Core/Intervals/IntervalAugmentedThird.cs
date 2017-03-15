namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

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

        public override string QualityName
            => "Augmented Third";

        public override string QualityAbbreviation
            => "A3";

        public override string QualityAbbreviation2
            => "3ᵗʰ ♯";

        public override string QualityComposition
            => "2 tons et 1 demi-ton chromatique";

        public override int Semitones
            => 5;
    }
}