namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalAugmentedSeventh : NoteQuality
    {
        public IntervalAugmentedSeventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedSeventh(string note)
            : base(note)
        {
        }

        public IntervalAugmentedSeventh(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedSeventh;

        public override string QualityName
            => "Augmented Seventh";

        public override string QualityAbbreviation
            => "A7";

        public override string QualityAbbreviation2
            => "7th Aug.";

        public override string QualityComposition
            => "Inusitée dans la pratique";

        public override int Semitones
            => 12;
    }
}