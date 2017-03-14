using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteSixthDiminished : NoteQuality
    {
        public NoteSixthDiminished(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSixthDiminished(string note)
            : base(note)
        {
        }

        public NoteSixthDiminished(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedSixth;

        public override string QualityName
            => "Sixth Diminished";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "2 tons et 3 demi-tons diatoniques";

        public override int Semitones
            => 7;
    }
}