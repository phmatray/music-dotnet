using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteThirdMinor : NoteQuality
    {
        public NoteThirdMinor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirdMinor(string note)
            : base(note)
        {
        }

        public NoteThirdMinor(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMinorThird;

        public override string QualityName
            => "Third Minor";

        public override string QualityAbbreviation
            => "3ʳᵈ min";

        public override string QualityComposition
            => "1 ton et 1 demi-ton diatonique";

        public override int Semitones
            => 3;
    }
}