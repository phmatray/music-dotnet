namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Notes;

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

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedEleventh;

        public override List<string> QualityName
            => new List<string> { "Augmented Eleventh" };

        public override List<string> QualityAbbreviation
            => new List<string> { "A11", "+11" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Aug. 11" };

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones { get; }
    }
}