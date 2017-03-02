namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSeventhMinor : NoteQuality
    {
        public NoteSeventhMinor(string note)
            : base(note)
        {
        }

        public NoteSeventhMinor(Note note)
            : base(note)
        {
        }

        public NoteSeventhMinor(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteSeventhMinor;

        public override string RoleName => "Seventh Minor";

        public override string RoleAbbreviation => "NO DATA";
    }
}