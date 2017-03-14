using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteFourthAugmented : NoteQuality
    {
        public NoteFourthAugmented(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteFourthAugmented(string note)
            : base(note)
        {
        }

        public NoteFourthAugmented(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedFourth;

        public override string QualityName
            => "Fourth Augmented";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "2 tons, 1 demi-ton diatonique et 1 demi-ton chromatique ou 3 tons(Triton)";

        public override int Semitones
            => 6;
    }
}