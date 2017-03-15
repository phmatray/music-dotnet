namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalMinorSixth : NoteQuality
    {
        public IntervalMinorSixth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMinorSixth(string note)
            : base(note)
        {
        }

        public IntervalMinorSixth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMinorSixth;

        public override List<string> QualityName
            => new List<string> { "Minor Sixth", "Minor Hexachord", "Hexachordon Minus", "Lesser Hexachord" };

        public override List<string> QualityAbbreviation
            => new List<string> { "m6" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "min. 6" };

        public override string QualityComposition
            => "3 tons et 2 demi-tons diatoniques";

        public override int Semitones
            => 8;
    }
}