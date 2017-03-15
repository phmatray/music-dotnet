namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

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

        public override List<string> QualityName
            => new List<string> { "Minor Thirteenth" };

        public override List<string> QualityAbbreviation
            => new List<string> { "m13" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "min. 13" };

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones { get; }
    }
}