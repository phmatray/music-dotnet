namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalMajorSeventh : NoteQuality
    {
        public IntervalMajorSeventh(string note)
            : base(note)
        {
        }

        public IntervalMajorSeventh(Note note)
            : base(note)
        {
        }

        public IntervalMajorSeventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMajorSeventh;

        public override string QualityName
            => "Major Seventh";

        public override string QualityAbbreviation
            => "M7";

        public override string QualityAbbreviation2
            => "NO DATA";

        public override string QualityComposition
            => "5 tons et 1 demi-ton diatonique";

        public override int Semitones
            => 11;
    }
}