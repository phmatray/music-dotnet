namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

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

        public override List<string> QualityName
            => new List<string> { "Perfect Eleventh" };

        public override List<string> QualityAbbreviation
            => new List<string> { "P11" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Perf. 11" };

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones { get; }
    }
}