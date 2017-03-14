namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteThirdMajor : NoteQuality
    {
        public NoteThirdMajor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirdMajor(string note)
            : base(note)
        {
        }

        public NoteThirdMajor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteThirdMajor;

        public override string QualityName
            => "Third Major";

        public override string QualityAbbreviation
            => "3ʳᵈ maj";

        public override string QualityComposition
            => "2 tons";
    }
}