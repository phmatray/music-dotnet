namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalPerfectOctave : NoteQuality
    {
        public IntervalPerfectOctave(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalPerfectOctave(string note)
            : base(note)
        {
        }

        public IntervalPerfectOctave(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalPerfectOctave;

        public override List<string> QualityName
            => new List<string> { "Perfect Octave" };

        public override List<string> QualityAbbreviation
            => new List<string> { "P8" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "Perf. 8" };

        public override string QualityComposition
            => "5 tons et 2 demi-tons diatoniques";

        public override int Semitones
            => 12;
    }
}