namespace MidiMinuit.Lib.Core.Notes
{
    public abstract class NoteQuality : Note
    {
        protected NoteQuality(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        protected NoteQuality(string note)
            : base(note)
        {
        }

        protected NoteQuality(Note note)
            : base(note)
        {
        }

        public abstract NoteQualityEnum Quality { get; }

        public abstract string RoleName { get; }

        public abstract string RoleAbbreviation { get; }
    }
}