using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteOctaveDiminished : NoteQuality
    {
        public NoteOctaveDiminished(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteOctaveDiminished(string note)
            : base(note)
        {
        }

        public NoteOctaveDiminished(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalDiminishedOctave;

        public override string QualityName
            => "Octave Diminished";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "4 tons et 3 demi-tons diatoniques";

        public override int Semitones
            => 11;
    }
}