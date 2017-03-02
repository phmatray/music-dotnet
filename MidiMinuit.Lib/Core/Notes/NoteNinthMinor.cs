namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteNinthMinor : NoteQuality
    {
        public NoteNinthMinor(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
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

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteNinthMinor;

        public override string RoleName => "Ninth Minor";

        public override string RoleAbbreviation => "NO DATA";
    }
}