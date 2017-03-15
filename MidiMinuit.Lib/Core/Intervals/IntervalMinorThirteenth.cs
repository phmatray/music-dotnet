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

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalMinorThirteenth;

        public override List<string> QualityName { get; }
            = new List<string> { "Minor Thirteenth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "m13" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "min. 13" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 20;

        public override NoteQuality Inverse { get; }
            = null;
    }
}