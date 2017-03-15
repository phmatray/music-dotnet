namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

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

        public override List<string> QualityName
            => new List<string> { "Major Ninth" };

        public override List<string> QualityAbbreviation
            => new List<string> { "M9" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Maj. 9" };

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones { get; }
    }
}