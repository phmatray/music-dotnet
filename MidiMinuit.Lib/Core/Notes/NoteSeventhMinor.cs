namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSeventhMinor : NoteQuality
    {
        public NoteSeventhMinor(string note)
            : base(note)
        {
        }

        public NoteSeventhMinor(Note note)
            : base(note)
        {
        }

        public NoteSeventhMinor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteSeventhMinor;

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