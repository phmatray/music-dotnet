namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalMajorSecond : NoteQuality
    {
        public IntervalMajorSecond(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMajorSecond(string note)
            : base(note)
        {
        }

        public IntervalMajorSecond(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMajorSecond;

        public override List<string> QualityName
            => new List<string> { "Major Second", "Tone", "Whole Tone", "Whole Step" };

        public override List<string> QualityAbbreviation
            => new List<string> { "M2" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Maj. 2" };

        public override string QualityComposition
            => "1 ton";

        public override int Semitones
            => 2;
    }
}