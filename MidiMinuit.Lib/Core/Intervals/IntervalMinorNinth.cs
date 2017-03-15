namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

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

        public override List<string> QualityName
            => new List<string> { "Minor Ninth" };

        public override List<string> QualityAbbreviation
            => new List<string> { "m9" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "min. 9" };

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones { get; }
    }
}