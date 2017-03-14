namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalAugmentedNinth : NoteQuality
    {
        public IntervalAugmentedNinth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedNinth(string note)
            : base(note)
        {
        }

        public IntervalAugmentedNinth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedNinth;

        public override string QualityName
            => "Augmented Ninth";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones { get; }
    }
}