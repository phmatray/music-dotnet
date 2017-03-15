namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalMajorSixth : NoteQuality
    {
        public IntervalMajorSixth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMajorSixth(string note)
            : base(note)
        {
        }

        public IntervalMajorSixth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMajorSixth;

        public override List<string> QualityName
            => new List<string> { "Major Sixth", "Septimal Major Sixth", "Supermajor Sixth", "Major Hexachord", "Greater Hexachord", "Hexachordon Maius" };

        public override List<string> QualityAbbreviation
            => new List<string> { "M6" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Maj. 6" };

        public override string QualityComposition
            => "4 tons et 1 demi-ton diatonique";

        public override int Semitones
            => 9;
    }
}