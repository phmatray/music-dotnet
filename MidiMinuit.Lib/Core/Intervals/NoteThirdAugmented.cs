using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteThirdAugmented : NoteQuality
    {
        public NoteThirdAugmented(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirdAugmented(string note)
            : base(note)
        {
        }

        public NoteThirdAugmented(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedThird;

        public override string QualityName
            => "Third Augmented";

        public override string QualityAbbreviation
            => "3ᵗʰ ♯";

        public override string QualityComposition
            => "2 tons et 1 demi-ton chromatique";

        public override int Semitones
            => 5;
    }
}