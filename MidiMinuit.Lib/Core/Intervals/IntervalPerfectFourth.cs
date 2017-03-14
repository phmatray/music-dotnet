namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalPerfectFourth : NoteQuality
    {
        public IntervalPerfectFourth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalPerfectFourth(string note)
            : base(note)
        {
        }

        public IntervalPerfectFourth(Note note)
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