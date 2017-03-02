namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteNinthMajor : NoteQuality
    {
        public NoteNinthMajor(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
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

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteNinthMajor;

        public override string RoleName => "Ninth Major";

        public override string RoleAbbreviation => "NO DATA";
    }
}