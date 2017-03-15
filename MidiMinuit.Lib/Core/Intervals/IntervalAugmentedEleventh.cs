namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalAugmentedEleventh : NoteQuality
    {
        public IntervalAugmentedEleventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedEleventh(string note)
            : base(note)
        {
        }

        public IntervalAugmentedEleventh(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalAugmentedEleventh;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Eleventh" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A11", "+11" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 11" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 18;

        public override NoteQuality Inverse { get; }
            = null;
    }
}