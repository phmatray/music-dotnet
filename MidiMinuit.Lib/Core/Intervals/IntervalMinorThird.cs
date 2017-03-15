namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalMinorThird : NoteQuality
    {
        public IntervalMinorThird(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMinorThird(string note)
            : base(note)
        {
        }

        public IntervalMinorThird(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalMinorThird;

        public override List<string> QualityName { get; }
            = new List<string> { "Minor Third" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "m3" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "min. 3" };

        public override string QualityComposition { get; }
            = "1 ton et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 3;

        public override NoteQuality Inverse { get; }
            = null;
    }
}