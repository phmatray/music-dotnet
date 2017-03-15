namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

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

        public override string QualityName
            => "Augmented Second";

        public override string QualityAbbreviation
            => "A2";

        public override string QualityAbbreviation2
            => "3nd Aug.";

        public override string QualityComposition
            => "1 ton et 1 demi-ton chromatique";

        public override int Semitones
            => 3;
    }
}