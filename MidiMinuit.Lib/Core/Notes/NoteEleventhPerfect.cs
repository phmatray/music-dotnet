namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteEleventhPerfect : NoteQuality
    {
        public NoteEleventhPerfect(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteEleventhPerfect(string note)
            : base(note)
        {
        }

        public NoteEleventhPerfect(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteEleventhPerfect;

        public override string QualityName
            => "Eleventh Perfect";

        public override string QualityAbbreviation
            => "NO DATA";
    }
}