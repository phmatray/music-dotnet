namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalMajorSeventh : NoteQuality
    {
        public IntervalMajorSeventh(string note)
            : base(note)
        {
        }

        public IntervalMajorSeventh(Note note)
            : base(note)
        {
        }

        public IntervalMajorSeventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMajorSeventh;

        public override List<string> QualityName
            => new List<string> { "Major Seventh", "Supermajor Seventh" };

        public override List<string> QualityAbbreviation
            => new List<string> { "M7" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Maj. 7" };

        public override string QualityComposition
            => "5 tons et 1 demi-ton diatonique";

        public override int Semitones
            => 11;
    }
}