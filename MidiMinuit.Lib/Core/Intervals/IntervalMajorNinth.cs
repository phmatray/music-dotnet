namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalMajorNinth : NoteQuality
    {
        public IntervalMajorNinth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMajorNinth(string note)
            : base(note)
        {
        }

        public IntervalMajorNinth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMajorNinth;

        public override string QualityName
            => "Major Ninth";

        public override string QualityAbbreviation
            => "M9";

        public override string QualityAbbreviation2
            => "NO DATA";

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones { get; }
    }
}