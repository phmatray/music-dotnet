using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteSecondMinor : NoteQuality
    {
        public NoteSecondMinor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSecondMinor(string note)
            : base(note)
        {
        }

        public NoteSecondMinor(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMinorSecond;

        public override string QualityName
            => "Second Minor";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "1 demi-ton diatonique";

        public override int Semitones
            => 1;
    }
}