namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalDiminishedFourth : NoteQuality
    {
        public IntervalDiminishedFourth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalDiminishedFourth(string note)
            : base(note)
        {
        }

        public IntervalDiminishedFourth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedFourth;

        public override List<string> QualityName
            => new List<string> { "Diminished Fourth" };

        public override List<string> QualityAbbreviation
            => new List<string> { "d4", "°4" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "deg. 4", "dim. 4" };

        public override string QualityComposition
            => "1 ton et 2 demi-tons diatoniques";

        public override int Semitones
            => 4;
    }
}