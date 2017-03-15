namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalMinorThird : NoteQuality
    {
        public IntervalMinorThird(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMinorThird(string note)
            : base(note)
        {
        }

        public IntervalMinorThird(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMinorThird;

        public override string QualityName
            => "Minor Third";

        public override string QualityAbbreviation
            => "m3";

        public override string QualityAbbreviation2
            => "3ʳᵈ min";

        public override string QualityComposition
            => "1 ton et 1 demi-ton diatonique";

        public override int Semitones
            => 3;
    }
}