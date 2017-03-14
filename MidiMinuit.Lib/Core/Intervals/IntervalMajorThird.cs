namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalMajorThird : NoteQuality
    {
        public IntervalMajorThird(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMajorThird(string note)
            : base(note)
        {
        }

        public IntervalMajorThird(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMajorThird;

        public override string QualityName
            => "Major Third";

        public override string QualityAbbreviation
            => "3ʳᵈ maj";

        public override string QualityComposition
            => "2 tons";

        public override int Semitones
            => 4;
    }
}