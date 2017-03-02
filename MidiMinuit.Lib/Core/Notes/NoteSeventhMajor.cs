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

        public NoteSeventhMajor(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteSeventhMajor;

        public override string RoleName => "Seventh Major";

        public override string RoleAbbreviation => "NO DATA";
    }
}