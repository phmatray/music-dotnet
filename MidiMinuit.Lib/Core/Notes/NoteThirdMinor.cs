namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteThirdMinor : NoteQuality
    {
        public NoteThirdMinor(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirdMinor(string note)
            : base(note)
        {
        }

        public NoteThirdMinor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteThirdMinor;

        public override string RoleName => "Third Minor";

        public override string RoleAbbreviation => "3rd min";
    }
}