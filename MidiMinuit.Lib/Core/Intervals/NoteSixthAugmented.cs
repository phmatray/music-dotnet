using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteSixthAugmented : NoteQuality
    {
        public NoteSixthAugmented(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSixthAugmented(string note)
            : base(note)
        {
        }

        public NoteSixthAugmented(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedSixth;

        public override string QualityName
            => "Sixth Augmented";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "4 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";

        public override int Semitones
            => 10;
    }
}