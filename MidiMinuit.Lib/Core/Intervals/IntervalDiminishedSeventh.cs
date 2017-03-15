namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalDiminishedSeventh : NoteQuality
    {
        public IntervalDiminishedSeventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalDiminishedSeventh(string note)
            : base(note)
        {
        }

        public IntervalDiminishedSeventh(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedSeventh;

        public override List<string> QualityName
            => new List<string> { "Diminished Seventh" };

        public override List<string> QualityAbbreviation
            => new List<string> { "d7", "°7" };

        public override List<string> QualityAbbreviation2
            => new List<string> { "deg. 7", "dim. 7" };

        public override string QualityComposition
            => "3 tons et 3 demi-tons diatoniques";

        public override int Semitones
            => 9;
    }
}