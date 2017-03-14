using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteThirdDiminished : NoteQuality
    {
        public NoteThirdDiminished(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirdDiminished(string note)
            : base(note)
        {
        }

        public NoteThirdDiminished(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedThird;

        public override string QualityName
            => "Third Diminished";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "2 demi-tons diatoniques";

        public override int Semitones
            => 2;
    }
}