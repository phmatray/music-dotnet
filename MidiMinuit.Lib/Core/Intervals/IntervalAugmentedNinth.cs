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

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalAugmentedNinth;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Ninth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A9", "+9" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 9" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 15;

        public override NoteQuality Inverse { get; }
            = null;
    }
}