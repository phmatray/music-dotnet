namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSecondMinor : NoteQuality
    {
        public NoteSecondMinor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSecondMinor(string note)
            : base(note)
        {
        }

        public NoteSecondMinor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteSecondMinor;

        public override string QualityName
            => "Second Minor";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "1 demi-ton diatonique";
    }
}