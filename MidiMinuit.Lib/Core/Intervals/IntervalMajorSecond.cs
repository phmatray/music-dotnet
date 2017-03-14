namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalMajorSecond : NoteQuality
    {
        public IntervalMajorSecond(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMajorSecond(string note)
            : base(note)
        {
        }

        public IntervalMajorSecond(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMajorSecond;

        public override string QualityName
            => "Major Second";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "1 ton";

        public override int Semitones
            => 2;
    }
}