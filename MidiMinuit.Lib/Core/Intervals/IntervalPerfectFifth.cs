namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalPerfectFifth : NoteQuality
    {
        public IntervalPerfectFifth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalPerfectFifth(string note)
            : base(note)
        {
        }

        public IntervalPerfectFifth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalPerfectFifth;

        public override List<string> QualityName { get; }
            = new List<string> { "Perfect Fifth", "Diapente" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "P5" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Perf. 5" };

        public override string QualityComposition { get; }
            = "3 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 7;

        public override NoteQuality Inverse { get; }
            = null;
    }
}