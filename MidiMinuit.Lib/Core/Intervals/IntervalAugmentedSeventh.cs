namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalAugmentedSeventh : NoteQuality
    {
        public IntervalAugmentedSeventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedSeventh(string note)
            : base(note)
        {
        }

        public IntervalAugmentedSeventh(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalAugmentedSeventh;

        public override List<string> QualityName
            => new List<string> { "Augmented Seventh" };

        public override List<string> QualityAbbreviation
            => new List<string> { "A7", "+7" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Aug. 7" };

        public override string QualityComposition
            => "Inusitée dans la pratique";

        public override int Semitones
            => 12;
    }
}