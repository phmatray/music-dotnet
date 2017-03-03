namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteThirteenthMinor : NoteQuality
    {
        public NoteThirteenthMinor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirteenthMinor(string note)
            : base(note)
        {
        }

        public NoteThirteenthMinor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteThirteenthMinor;

        public override string QualityName
            => "Thirteenth Minor";

        public override string QualityAbbreviation
            => "NO DATA";
    }
}