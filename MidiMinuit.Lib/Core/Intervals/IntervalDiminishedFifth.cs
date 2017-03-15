namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalDiminishedFifth : NoteQuality
    {
        public IntervalDiminishedFifth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalDiminishedFifth(string note)
            : base(note)
        {
        }

        public IntervalDiminishedFifth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedFifth;

        public override string QualityName
            => "Diminished Fifth";

        public override string QualityAbbreviation
            => "d5";

        public override string QualityAbbreviation2
            => "NO DATA";

        public override string QualityComposition
            => "2 tons et 2 demi-tons diatoniques";

        public override int Semitones
            => 6;
    }
}