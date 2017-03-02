namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteFourthAugmented : NoteQuality
    {
        public NoteFourthAugmented(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteFourthAugmented(string note)
            : base(note)
        {
        }

        public NoteFourthAugmented(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteFourthAugmented;

        public override string RoleName => "Fourth Augmented";

        public override string RoleAbbreviation => "NO DATA";
    }
}