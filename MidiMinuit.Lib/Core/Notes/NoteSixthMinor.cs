namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSixthMinor : NoteQuality
    {
        public NoteSixthMinor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSixthMinor(string note)
            : base(note)
        {
        }

        public NoteSixthMinor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteSixthMinor;

        public override string QualityName
            => "Sixth Minor";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "3 tons et 2 demi-tons diatoniques";

        public override int Semitones
            => 8;
    }
}