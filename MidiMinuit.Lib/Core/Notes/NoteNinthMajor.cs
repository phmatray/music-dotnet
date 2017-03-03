namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteNinthMajor : NoteQuality
    {
        public NoteNinthMajor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteNinthMajor(string note)
            : base(note)
        {
        }

        public NoteNinthMajor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteNinthMajor;

        public override string QualityName
            => "Ninth Major";

        public override string QualityAbbreviation
            => "NO DATA";
    }
}