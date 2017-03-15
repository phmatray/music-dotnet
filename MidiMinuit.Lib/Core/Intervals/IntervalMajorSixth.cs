namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalMajorSixth : NoteQuality
    {
        public IntervalMajorSixth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMajorSixth(string note)
            : base(note)
        {
        }

        public IntervalMajorSixth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMajorSixth;

        public override string QualityName
            => "Major Sixth";

        public override string QualityAbbreviation
            => "M6";

        public override string QualityAbbreviation2
            => "NO DATA";

        public override string QualityComposition
            => "4 tons et 1 demi-ton diatonique";

        public override int Semitones
            => 9;
    }
}