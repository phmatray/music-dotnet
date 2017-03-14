namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalAugmentedUnison : NoteQuality
    {
        public IntervalAugmentedUnison(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedUnison(string note)
            : base(note)
        {
        }

        public IntervalAugmentedUnison(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedUnison;

        public override string QualityName
            => "Unison Augmented";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones
            => 1;
    }
}