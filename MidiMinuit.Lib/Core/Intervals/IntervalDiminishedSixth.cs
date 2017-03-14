namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalDiminishedSixth : NoteQuality
    {
        public IntervalDiminishedSixth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalDiminishedSixth(string note)
            : base(note)
        {
        }

        public IntervalDiminishedSixth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedSixth;

        public override string QualityName
            => "Diminished Sixth";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "2 tons et 3 demi-tons diatoniques";

        public override int Semitones
            => 7;
    }
}