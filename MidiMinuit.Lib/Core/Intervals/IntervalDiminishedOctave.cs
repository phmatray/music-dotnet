namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalDiminishedOctave : NoteQuality
    {
        public IntervalDiminishedOctave(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalDiminishedOctave(string note)
            : base(note)
        {
        }

        public IntervalDiminishedOctave(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedOctave;

        public override string QualityName
            => "Diminished Octave";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "4 tons et 3 demi-tons diatoniques";

        public override int Semitones
            => 11;
    }
}