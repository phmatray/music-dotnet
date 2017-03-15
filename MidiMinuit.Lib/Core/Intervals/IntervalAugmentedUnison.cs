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
            => "Augmented Unison";

        public override string QualityAbbreviation
            => "A1";

        public override string QualityAbbreviation2
            => "1st Aug.";

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones
            => 1;
    }
}