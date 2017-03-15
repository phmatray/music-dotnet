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

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedOctave;

        public override List<string> QualityName
            => new List<string> { "Diminished Octave", "Diminished Eighth" };

        public override List<string> QualityAbbreviation
            => new List<string> { "d8", "°8" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "deg. 8", "dim. 8" };

        public override string QualityComposition
            => "4 tons et 3 demi-tons diatoniques";

        public override int Semitones
            => 11;
    }
}