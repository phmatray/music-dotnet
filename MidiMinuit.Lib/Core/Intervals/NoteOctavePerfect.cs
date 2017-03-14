using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteOctavePerfect : NoteQuality
    {
        public NoteOctavePerfect(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteOctavePerfect(string note)
            : base(note)
        {
        }

        public NoteOctavePerfect(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalPerfectOctave;

        public override string QualityName
            => "Octave Perfect";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "5 tons et 2 demi-tons diatoniques";

        public override int Semitones
            => 12;
    }
}