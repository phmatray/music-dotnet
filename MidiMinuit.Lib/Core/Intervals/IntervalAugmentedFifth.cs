namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

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

        public override string QualityName
            => "Fifth Augmented";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "3 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones
            => 8;
    }
}