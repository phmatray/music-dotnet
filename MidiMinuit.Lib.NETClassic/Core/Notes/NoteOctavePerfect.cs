namespace MidiMinuit.Lib.Core.Notes
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

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteOctavePerfect;

        public override string QualityName
            => "Octave Perfect";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "5 tons et 2 demi-tons diatoniques";
    }
}