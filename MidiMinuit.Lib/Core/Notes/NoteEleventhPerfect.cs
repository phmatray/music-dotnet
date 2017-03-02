namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteEleventhPerfect : NoteQuality
    {
        public NoteEleventhPerfect(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
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

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteEleventhPerfect;

        public override string RoleName => "Eleventh Perfect";

        public override string RoleAbbreviation => "NO DATA";
    }
}