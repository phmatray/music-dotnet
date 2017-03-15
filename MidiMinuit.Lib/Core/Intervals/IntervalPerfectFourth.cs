namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalPerfectFourth : NoteQuality
    {
        public IntervalPerfectFourth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalPerfectFourth(string note)
            : base(note)
        {
        }

        public IntervalPerfectFourth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalPerfectFourth;

        public override List<string> QualityName
            => new List<string> { "Perfect Fourth", "Diatessaron" };

        public override List<string> QualityAbbreviation
            => new List<string> { "P4" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Perf. 4" };

        public override string QualityComposition
            => "2 tons et 1 demi-ton diatonique";

        public override int Semitones
            => 5;
    }
}