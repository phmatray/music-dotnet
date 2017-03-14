using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteFourthPerfect : NoteQuality
    {
        public NoteFourthPerfect(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteFourthPerfect(string note)
            : base(note)
        {
        }

        public NoteFourthPerfect(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalPerfectFourth;

        public override string QualityName
            => "Fourth Perfect";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "2 tons et 1 demi-ton diatonique";

        public override int Semitones
            => 5;
    }
}