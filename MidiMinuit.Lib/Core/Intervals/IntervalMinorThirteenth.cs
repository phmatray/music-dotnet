namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalMinorThirteenth : NoteQuality
    {
        public IntervalMinorThirteenth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMinorThirteenth(string note)
            : base(note)
        {
        }

        public IntervalMinorThirteenth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMinorThirteenth;

        public override string QualityName
            => "Minor Thirteenth";

        public override string QualityAbbreviation
            => "m13";

        public override string QualityAbbreviation2
            => "NO DATA";

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones { get; }
    }
}