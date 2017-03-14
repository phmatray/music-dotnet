namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteThirteenthMajor : NoteQuality
    {
        public NoteThirteenthMajor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirteenthMajor(string note)
            : base(note)
        {
        }

        public NoteThirteenthMajor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteThirteenthMajor;

        public override string QualityName
            => "Thirteenth Major";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones { get; }
    }
}