namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalMajorThird : NoteQuality
    {
        public IntervalMajorThird(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMajorThird(string note)
            : base(note)
        {
        }

        public IntervalMajorThird(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMajorThird;

        public override List<string> QualityName
            => new List<string> { "Major Third" };

        public override List<string> QualityAbbreviation
            => new List<string> { "M3" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Maj. 3" };

        public override string QualityComposition
            => "2 tons";

        public override int Semitones
            => 4;
    }
}