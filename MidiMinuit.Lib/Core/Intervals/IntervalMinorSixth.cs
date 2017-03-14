namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalMinorSixth : NoteQuality
    {
        public IntervalMinorSixth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMinorSixth(string note)
            : base(note)
        {
        }

        public IntervalMinorSixth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMinorSixth;

        public override string QualityName
            => "Minor Sixth";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "3 tons et 2 demi-tons diatoniques";

        public override int Semitones
            => 8;
    }
}