namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalMajorThirteenth : NoteQuality
    {
        public IntervalMajorThirteenth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMajorThirteenth(string note)
            : base(note)
        {
        }

        public IntervalMajorThirteenth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalMajorThirteenth;

        public override List<string> QualityName { get; }
            = new List<string> { "Major Thirteenth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "M13" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Maj. 13" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 21;

        public override NoteQuality Inverse { get; }
            = null;
    }
}