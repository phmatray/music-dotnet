using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteFourthDiminished : NoteQuality
    {
        public NoteFourthDiminished(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteFourthDiminished(string note)
            : base(note)
        {
        }

        public NoteFourthDiminished(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedFourth;

        public override string QualityName
            => "Fourth Diminished";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "1 ton et 2 demi-tons diatoniques";

        public override int Semitones
            => 4;
    }
}