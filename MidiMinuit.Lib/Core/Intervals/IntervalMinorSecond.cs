namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalMinorSecond : NoteQuality
    {
        public IntervalMinorSecond(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMinorSecond(string note)
            : base(note)
        {
        }

        public IntervalMinorSecond(Note note)
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