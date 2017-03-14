using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteSecondAugmented : NoteQuality
    {
        public NoteSecondAugmented(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSecondAugmented(string note)
            : base(note)
        {
        }

        public NoteSecondAugmented(Note note)
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