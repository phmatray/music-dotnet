namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalDiminishedThird : NoteQuality
    {
        public IntervalDiminishedThird(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalDiminishedThird(string note)
            : base(note)
        {
        }

        public IntervalDiminishedThird(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedThird;

        public override string QualityName
            => "Diminished Third";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "2 demi-tons diatoniques";

        public override int Semitones
            => 2;
    }
}