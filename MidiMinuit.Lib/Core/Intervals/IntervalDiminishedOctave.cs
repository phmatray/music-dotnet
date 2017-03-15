namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalDiminishedOctave : NoteQuality
    {
        public IntervalDiminishedOctave(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalDiminishedOctave(string note)
            : base(note)
        {
        }

        public IntervalDiminishedOctave(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalDiminishedOctave;

        public override List<string> QualityName { get; }
            = new List<string> { "Diminished Octave", "Diminished Eighth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "d8", "°8" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "deg. 8", "dim. 8" };

        public override string QualityComposition { get; }
            = "4 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; }
            = 11;

        public override NoteQuality Inverse { get; }
            = null;
    }
}