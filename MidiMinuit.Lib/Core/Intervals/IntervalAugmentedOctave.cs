namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalAugmentedOctave : NoteQuality
    {
        public IntervalAugmentedOctave(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedOctave(string note)
            : base(note)
        {
        }

        public IntervalAugmentedOctave(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedOctave;

        public override string QualityName
            => "Augmented Octave";

        public override string QualityAbbreviation
            => "A8";

        public override string QualityAbbreviation2
            => "8th Aug.";

        public override string QualityComposition
            => "5 tons, 2 demi-tons diatoniques et 1 demi-ton chromatique";

        public override int Semitones { get; }
    }
}