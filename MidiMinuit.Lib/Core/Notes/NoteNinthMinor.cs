namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteNinthMinor : NoteQuality
    {
        public NoteNinthMinor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteNinthMinor(string note)
            : base(note)
        {
        }

        public NoteNinthMinor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteNinthMinor;

        public override string QualityName
            => "Ninth Minor";

        public override string QualityAbbreviation
            => "NO DATA";
    }
}