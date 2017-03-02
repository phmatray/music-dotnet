namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSixthMajor : NoteQuality
    {
        public NoteSixthMajor(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSixthMajor(string note)
            : base(note)
        {
        }

        public NoteSixthMajor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteSixthMajor;

        public override string RoleName => "Sixth Major";

        public override string RoleAbbreviation => "NO DATA";
    }
}