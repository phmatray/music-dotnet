namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSeventhMajor : NoteQuality
    {
        public NoteSeventhMajor(string note)
            : base(note)
        {
        }

        public NoteSeventhMajor(Note note)
            : base(note)
        {
        }

        public NoteSeventhMajor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteSeventhMajor;

        public override string QualityName
            => "Seventh Major";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "5 tons et 1 demi-ton diatonique";
    }
}