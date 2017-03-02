namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSecondAugmented : NoteQuality
    {
        public NoteSecondAugmented(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSecondAugmented(string note)
            : base(note)
        {
        }

        public NoteSecondAugmented(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteSecondAugmented;

        public override string RoleName => "Second Augmented";

        public override string RoleAbbreviation => "NO DATA";
    }
}