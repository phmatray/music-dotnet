namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalAugmentedNinth : NoteQuality
    {
        public IntervalAugmentedNinth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedNinth(string note)
            : base(note)
        {
        }

        public IntervalAugmentedNinth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedNinth;

        public override List<string> QualityName
            => new List<string> { "Augmented Ninth" };

        public override List<string> QualityAbbreviation
            => new List<string> { "A9", "+9" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Aug. 9" };

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones { get; }
    }
}