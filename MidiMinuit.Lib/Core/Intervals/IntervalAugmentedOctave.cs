namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalAugmentedOctave : NoteQuality
    {
        public IntervalAugmentedOctave(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalAugmentedOctave(string note)
            : base(note)
        {
        }

        public IntervalAugmentedOctave(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalAugmentedOctave;

        public override List<string> QualityName { get; }
            = new List<string> { "Augmented Octave", "Augmented Eighth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "A8", "+8" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Aug. 8" };

        public override string QualityComposition { get; }
            = "5 tons, 2 demi-tons diatoniques et 1 demi-ton chromatique";

        public override int Semitones { get; }
            = 13;

        public override NoteQuality Inverse { get; }
            = null;
    }
}