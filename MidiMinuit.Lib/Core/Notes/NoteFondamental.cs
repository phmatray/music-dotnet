namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteFondamental : NoteQuality
    {
        public NoteFondamental(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteFondamental(string note)
            : base(note)
        {
        }

        public NoteFondamental(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteFondamental;

        public override string RoleName => "Fondamental";

        public override string RoleAbbreviation => "Fond";
    }
}