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
            => "Second Augmented";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "1 ton et 1 demi-ton chromatique";

        public override int Semitones
            => 3;
    }
}