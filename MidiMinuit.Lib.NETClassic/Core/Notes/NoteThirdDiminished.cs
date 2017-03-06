namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteThirdDiminished : NoteQuality
    {
        public NoteThirdDiminished(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirdDiminished(string note)
            : base(note)
        {
        }

        public NoteThirdDiminished(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteThirdDiminished;

        public override string QualityName
            => "Third Diminished";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "2 demi-tons diatoniques";
    }
}