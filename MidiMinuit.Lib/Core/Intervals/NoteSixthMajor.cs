using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteSixthMajor : NoteQuality
    {
        public NoteSixthMajor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSixthMajor(string note)
            : base(note)
        {
        }

        public NoteSixthMajor(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMajorSixth;

        public override string QualityName
            => "Sixth Major";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "4 tons et 1 demi-ton diatonique";

        public override int Semitones
            => 9;
    }
}