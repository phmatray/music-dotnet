namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalMinorSeventh : NoteQuality
    {
        public IntervalMinorSeventh(string note)
            : base(note)
        {
        }

        public IntervalMinorSeventh(Note note)
            : base(note)
        {
        }

        public IntervalMinorSeventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMinorSeventh;

        public override List<string> QualityName
            => new List<string> { "Minor Seventh" };

        public override List<string> QualityAbbreviation
            => new List<string> { "m7" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "min. 7" };

        public override string QualityComposition
            => "4 tons et 2 demi-tons diatoniques";

        public override int Semitones
            => 10;
    }
}