namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalDiminishedSecond : NoteQuality
    {
        public IntervalDiminishedSecond(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalDiminishedSecond(string note)
            : base(note)
        {
        }

        public IntervalDiminishedSecond(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedSecond;

        public override List<string> QualityName
            => new List<string> { "Diminished Second" };

        public override List<string> QualityAbbreviation
            => new List<string> { "d2", "°2" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "deg. 2", "dim. 2" };

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones
            => 0;
    }
}