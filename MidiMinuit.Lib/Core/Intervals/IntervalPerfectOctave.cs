namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalPerfectOctave : NoteQuality
    {
        public IntervalPerfectOctave(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalPerfectOctave(string note)
            : base(note)
        {
        }

        public IntervalPerfectOctave(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalPerfectOctave;

        public override string QualityName
            => "Perfect Octave";

        public override string QualityAbbreviation
            => "P8";

        public override string QualityAbbreviation2
            => "NO DATA";

        public override string QualityComposition
            => "5 tons et 2 demi-tons diatoniques";

        public override int Semitones
            => 12;
    }
}