namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteFifthAugmented : NoteQuality
    {
        public NoteFifthAugmented(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteFifthAugmented(string note)
            : base(note)
        {
        }

        public NoteFifthAugmented(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteFifthAugmented;

        public override string RoleName => "Fifth Augmented";

        public override string RoleAbbreviation => "NO DATA";
    }
}