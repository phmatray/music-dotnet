namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalDiminishedSeventh : NoteQuality
    {
        public IntervalDiminishedSeventh(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalDiminishedSeventh(string note)
            : base(note)
        {
        }

        public IntervalDiminishedSeventh(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedSeventh;

        public override string QualityName
            => "Diminished Seventh";

        public override string QualityAbbreviation
            => "7th dim";

        public override string QualityComposition
            => "3 tons et 3 demi-tons diatoniques";

        public override int Semitones
            => 9;
    }
}