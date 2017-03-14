using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteFifthPerfect : NoteQuality
    {
        public NoteFifthPerfect(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteFifthPerfect(string note)
            : base(note)
        {
        }

        public NoteFifthPerfect(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalPerfectFifth;

        public override string QualityName
            => "Fifth Perfect";

        public override string QualityAbbreviation
            => "5ᵗʰ";

        public override string QualityComposition
            => "3 tons et 1 demi-ton diatonique";

        public override int Semitones
            => 7;
    }
}