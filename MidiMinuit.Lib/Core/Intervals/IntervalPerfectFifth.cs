namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalPerfectFifth : NoteQuality
    {
        public IntervalPerfectFifth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalPerfectFifth(string note)
            : base(note)
        {
        }

        public IntervalPerfectFifth(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalPerfectFifth;

        public override string QualityName
            => "Perfect Fifth";

        public override string QualityAbbreviation
            => "5ᵗʰ";

        public override string QualityComposition
            => "3 tons et 1 demi-ton diatonique";

        public override int Semitones
            => 7;
    }
}