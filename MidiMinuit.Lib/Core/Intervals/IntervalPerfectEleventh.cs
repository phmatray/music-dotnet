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

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalPerfectEleventh;

        public override List<string> QualityName { get; }
            = new List<string> { "Perfect Eleventh" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "P11" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Perf. 11" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 17;

        public override NoteQuality Inverse { get; }
            = null;
    }
}