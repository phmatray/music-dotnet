namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalDiminishedSixth : NoteQuality
    {
        public IntervalDiminishedSixth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalDiminishedSixth(string note)
            : base(note)
        {
        }

        public IntervalDiminishedSixth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedSixth;

        public override List<string> QualityName
            => new List<string> { "Diminished Sixth" };

        public override List<string> QualityAbbreviation
            => new List<string> { "d6", "°6" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "deg. 6", "dim. 6" };

        public override string QualityComposition
            => "2 tons et 3 demi-tons diatoniques";

        public override int Semitones
            => 7;
    }
}