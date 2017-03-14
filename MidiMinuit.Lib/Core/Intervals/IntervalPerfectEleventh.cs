namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalPerfectEleventh : NoteQuality
    {
        public IntervalPerfectEleventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalPerfectEleventh(string note)
            : base(note)
        {
        }

        public IntervalPerfectEleventh(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalPerfectEleventh;

        public override string QualityName
            => "Perfect Eleventh";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones { get; }
    }
}