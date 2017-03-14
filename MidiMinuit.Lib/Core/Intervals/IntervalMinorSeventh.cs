namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalMinorSeventh : NoteQuality
    {
        public IntervalMinorSeventh(string note)
            : base(note)
        {
        }

        public IntervalMinorSeventh(Note note)
            : base(note)
        {
        }

        public IntervalMinorSeventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMinorSeventh;

        public override string QualityName
            => "Seventh Minor";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "4 tons et 2 demi-tons diatoniques";

        public override int Semitones
            => 10;
    }
}