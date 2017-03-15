namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalMinorNinth : NoteQuality
    {
        public IntervalMinorNinth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMinorNinth(string note)
            : base(note)
        {
        }

        public IntervalMinorNinth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMinorNinth;

        public override string QualityName
            => "Minor Ninth";

        public override string QualityAbbreviation
            => "m9";

        public override string QualityAbbreviation2
            => "NO DATA";

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones { get; }
    }
}